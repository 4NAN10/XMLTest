using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlTest
{
    class XmlTest
    {
        static void Main(string[] args)
        {
            // XMLファイルの読み込み準備
            System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Ryohei\source\repos\XmlTest\XMLFile1.xml", System.IO.FileMode.Open);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(XmlRoot));
            XmlRoot groupingXml = (XmlRoot)serializer.Deserialize(fs);

            // <Domains>(ルート)はListで<Domain>を保有
            // ループで<Dmain>を1つ取得
            foreach (XmlDomain Domain in groupingXml.Domains)
            {
                Console.WriteLine(Domain.Name);

                // <Domain>は<Files>を単体で取得
                // インスタンスを生成する
                XmlFiles Files = Domain.Files;

                // <Files>はListで<File>を保有
                // ループで<File>を1つ取得
                foreach (XmlFile File in Files.Files)
                {
                    Console.WriteLine(File.Name);
                    // <File>はListで<Item>を保有
                    // ループで<item>を1つ取得
                    foreach (XmlItem item in File.Items)
                    {
                        Console.WriteLine(String.Format("name= {0} : value= {1}", item.Name, item.Value));
                    }
                }
            }

            Console.Read();
        }
    }
}
