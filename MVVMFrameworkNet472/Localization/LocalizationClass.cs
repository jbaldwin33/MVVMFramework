using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MVVMFrameworkNet472.Localization
{
    [XmlRoot("Localization")]
    public class LocalizationClass
    {
        [DataMember] public int PreferredLCID { get; set; }
        [DataMember] public List<TranslatableElement> Items { get; set; } = new List<TranslatableElement>();

        public class TranslatableElement
        {
            [DataMember] public string Name { get; set; }
            [DataMember] public Translation[] Items { get; set; }

            public class Translation
            {
                [DataMember] public string Text { get; set; }
                [DataMember]
                public string LCID
                {
                    get => string.Join(",", LCIDArray ?? Array.Empty<int>());
                    set => LCIDArray = value.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                }
                internal int[] LCIDArray { get; set; }
            }
        }
    }
}
