using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MCD_SystemXMLKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region XML Data Yazma
            /*XmlTextWriter xmlText = new XmlTextWriter(@"c:\\XML\\Personellerim.xml", System.Text.UTF8Encoding.UTF8);
            // <!---YORUM--->
            xmlText.WriteComment("Yorumlar buraya yazılır");
            //root oluşturma
            xmlText.WriteStartElement("Personellerim");
            //child oluşturma
            xmlText.WriteStartElement("Personel");
            xmlText.WriteAttributeString("ID", "1");
            xmlText.WriteElementString("İsim", "Ahmet");
            xmlText.WriteElementString("Soyisim", "Koç");
            xmlText.WriteElementString("EmailAdres", "ahmet.koc@gmail.com");
            xmlText.WriteEndElement();//child kapatır
            //yeni child
            xmlText.WriteStartElement("Personel");
            xmlText.WriteAttributeString("ID", "2");
            xmlText.WriteElementString("İsim", "Mehmet");
            xmlText.WriteElementString("Soyisim", "Kat");
            xmlText.WriteElementString("EmailAdres", "mehmet.kat@gmail.com");
            xmlText.WriteEndElement();

            xmlText.WriteEndElement();//root kapatır
            xmlText.Close();*/
            #endregion


            #region XML Data Okuma

            XmlReader xRead = XmlReader.Create(@"c:\\XML\\Personellerim.xml");
            while (xRead.Read())
            {
                Console.WriteLine($"{xRead.Name.ToString()}-{xRead.Value.ToString()}");
            }

            #endregion
        }
    }
}
