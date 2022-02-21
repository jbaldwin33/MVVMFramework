using MVVMFramework.Localization;
using System;

namespace TranslatableAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = TranslatableClass.Instance;
            instance.AddToLocalizationFile();
            Console.ReadLine();
        }
    }
}
