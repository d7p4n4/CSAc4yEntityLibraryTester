
using CSAc4yClass.Class;
using d7p4n4.EFMethods.Class;
using d7p4n4.Final.Class;
using d7p4n4Namespace.EFMethods.Class;
using d7p4n4Namespace.Final.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSAc4yEntityLibraryTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Ac4ySDSequenceEntityMethods ac4YSDSequenceEntityMethods = new Ac4ySDSequenceEntityMethods("Ac4ySD2");

            Ac4ySDSequence sequence = new Ac4ySDSequence()
            {
                Communication = new List<Ac4ySDCommunication>()
               {
                   new Ac4ySDCommunication()
                   {
                       Sender = new Ac4ySDParticipant(){ Name = "frontend" }
                       ,Receiver = new Ac4ySDParticipant(){ Name = "backend" }
                       ,Message = new Ac4ySDMessage(){ Message = "login" }
                   }
                   ,new Ac4ySDCommunication()
                   {
                       Sender = new Ac4ySDParticipant(){ Name = "backend" }
                       ,Receiver = new Ac4ySDParticipant(){ Name = "frontend" }
                       ,Message = new Ac4ySDMessage(){ Message = "ok" }
                   }
               }
            };

            LoadAndSaveXML lasx = new LoadAndSaveXML();

            //lasx.SaveWithXml(sequence, ac4YSDSequenceEntityMethods);

            lasx.LoadXmlById(10, ac4YSDSequenceEntityMethods);

            /*
            Ac4yChildEntityMethods ac4YEntityMethods = new Ac4yChildEntityMethods("Ac4yDb2");

            Ac4yChild ac4yChild = new Ac4yChild()
            {
                FirstName = "Jack",
                HumanId = "ac4yChild",
                serialization = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Ac4yClass xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><Name>Ac4yChild</Name><Ancestor>Ac4y</Ancestor><Namespace>CSAc4yObjectService.Class</Namespace><GUID /><PropertyList><Ac4yProperty><Name>FirstName</Name><Type>String</Type></Ac4yProperty><Ac4yProperty><Name>LastName</Name><Type>String</Type></Ac4yProperty></PropertyList></Ac4yClass>",
                template = new Ac4yIdentificationBase()
                {
                    HumanId = "ac4ytemplate",
                }
            };

            //ac4YEntityMethods.addNew(ac4yChild);
            /*
            Ac4yChild ac4yChild2 = ac4YEntityMethods.findFirstById(6);
            Console.WriteLine(ac4yChild2.FirstName);

            string xml = ac4yChild2.serialization;
            Console.WriteLine(ac4yChild2.serialization);

            Ac4yClass ac4yChild3 = null;

            XmlSerializer serializer = new XmlSerializer(typeof(Ac4yClass));

            StringReader reader = new StringReader(xml);
            ac4yChild3 = (Ac4yClass)serializer.Deserialize(reader);
            reader.Close();
            */


        }
    }
}
