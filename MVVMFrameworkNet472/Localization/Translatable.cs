using System.Linq;

namespace MVVMFrameworkNet472.Localization
{
    public abstract class Translatable
    {
        private readonly object[] parameters;
        private readonly TranslatableClass localizationCache;
        
        protected Translatable(params object[] args)
        {
            parameters = args;
            localizationCache = TranslatableClass.Instance;
        }

        protected abstract string GetDefaultTranslation();

        public override string ToString() => string.Format(GetTranslation(), parameters);

        public static implicit operator string(Translatable translatable) => translatable.ToString();

        public string GetTranslation()
        {
            var translation = GetDefaultTranslation();
            var elements = localizationCache.LocalizationFile.Items.Where(translatableElement => translatableElement.Name == GetType().FullName);
            foreach (var translatableElement in elements)
                translation = translatableElement.Items.First(x => int.Parse(x.LCID) == x.LCIDArray.FirstOrDefault(lcid => lcid == localizationCache.CurrentLCID)).Text;
            return translation;
        }
    }
}
