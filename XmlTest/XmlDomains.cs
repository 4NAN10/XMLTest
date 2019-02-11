using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlTest
{
    /// <summary>
    /// ドメイン一覧(ルート)
    /// </summary>
    [System.Xml.Serialization.XmlRoot("Domains")]
    public class XmlRoot
    {
        [System.Xml.Serialization.XmlElement("Domain")]
        public List<XmlDomain> Domains { get; set; } = new List<XmlDomain>();
    }

    /// <summary>
    /// ドメイン
    /// </summary>
    public class XmlDomain
    {
        [System.Xml.Serialization.XmlAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElement("Files")]
        public XmlFiles Files { get; set; }

        public string Read(string name)
        {
            return this.Name;
        }
    }

    /// <summary>
    /// ファイル一覧
    /// </summary>
    public class XmlFiles
    {
        [System.Xml.Serialization.XmlElement("File")]
        public List<XmlFile> Files { get; set; } = new List<XmlFile>();
    }

    /// <summary>
    /// ファイル
    /// </summary>
    public class XmlFile
    {
        [System.Xml.Serialization.XmlAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElement("item")]
        public List<XmlItem> Items = new List<XmlItem>();

        public string Read()
        {
            return this.Name;
        }
    }

    /// <summary>
    /// アイテム
    /// </summary>
    public class XmlItem
    {
        [System.Xml.Serialization.XmlAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlAttribute("value")]
        public string Value { get; set; }
    }
}
