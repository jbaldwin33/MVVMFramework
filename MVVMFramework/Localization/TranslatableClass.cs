using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace MVVMFramework.Localization
{
    public class TranslatableClass
    {
        private static readonly Lazy<TranslatableClass> lazy = new Lazy<TranslatableClass>(() => new TranslatableClass());
        public static TranslatableClass Instance => lazy.Value;
        public LocalizationClass LocalizationFile;
        private CultureInfo currentCultureInfo;
        public CultureInfo CurrentCultureInfo
        {
            get => currentCultureInfo;
            set
            {
                currentCultureInfo = value;
                CurrentLCID = value.LCID;
            }
        }
        public int CurrentLCID { get; private set; }
        private static XmlSerializer _xmlSerializer;
        private static XmlSerializer xmlSerializer => _xmlSerializer ?? (_xmlSerializer = new XmlSerializer(typeof(LocalizationClass)));
        private static readonly string masterLocalizationPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Localization", "Localization.xml");
        private TranslatableClass()
        {
            if (string.IsNullOrEmpty(masterLocalizationPath))
                throw new Exception("Cannot read 'binaryFolder' variable from app.config / web.config.");
            if (!File.Exists(masterLocalizationPath))
            {
                using (var stringWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(stringWriter, LocalizationFile);
                    File.WriteAllText(masterLocalizationPath, stringWriter.ToString(), Encoding.Unicode);
                }
            }
            using (var reader = new StreamReader(masterLocalizationPath))
                LocalizationFile = (LocalizationClass)xmlSerializer.Deserialize(reader) ?? new LocalizationClass();
            CurrentCultureInfo = CultureInfo.CurrentUICulture;
        }

        public void AddToLocalizationFile()
        {
            var translatables = ReflectiveEnumerator.GetEnumerableOfType<Translatable>();
            foreach (var translatable in translatables)
            {
                if (LocalizationFile.Items.Any(i => i.Name == translatable.GetType().FullName))
                    continue;
                
                LocalizationFile.Items.Add(new LocalizationClass.TranslatableElement
                {
                    Name = translatable.GetType().FullName,
                    Items = new[]
                    {
                        new LocalizationClass.TranslatableElement.Translation
                        {
                            Text = translatable.GetTranslation(),
                            LCIDArray = new[] { 1033 }
                        }
                    }
                });
                Console.WriteLine($"{nameof(translatable)} added.");
            }

            SaveFile();
        }

        private void SaveFile()
        {
            using (var stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, LocalizationFile);
                //File.WriteAllText(localizationPath, stringWriter.ToString(), Encoding.Unicode);
                File.WriteAllText(masterLocalizationPath, stringWriter.ToString(), Encoding.Unicode);
            }
            Console.WriteLine("Localization file saved.");
        }
    }

    public static class ReflectiveEnumerator
    {
        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
        {
            Type[] types;
            try
            {
                types = Assembly.GetAssembly(typeof(T)).GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                types = e.Types;
            }

            var newTypes = types.Where(myType => myType != null && myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T)));
            return newTypes.Select(type => (T)Activator.CreateInstance(type, constructorArgs));
        }
    }
}
