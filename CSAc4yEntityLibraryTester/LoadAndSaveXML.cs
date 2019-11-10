using d7p4n4Namespace.EFMethods.Class;
using d7p4n4Namespace.Final.Class;
using d7p4n4Namespace.PreProcessed.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CSAc4yEntityLibraryTester
{
    class LoadAndSaveXML
    {
        public Ac4ySDSequence LoadXmlById(int id, Ac4ySDSequenceEntityMethods ySDSequenceEntityMethods)
        {
            Ac4ySDSequence ac4YSDSequence = ySDSequenceEntityMethods.findFirstById(id);

            string xml = ac4YSDSequence.serialization;

            Ac4ySDSequence ySDSequence = null;

            XmlSerializer serializer = new XmlSerializer(typeof(Ac4ySDSequence));

            StringReader reader = new StringReader(xml);
            ySDSequence = (Ac4ySDSequence)serializer.Deserialize(reader);
            reader.Close();

            return ySDSequence;
        }

        public void SaveWithXml(Ac4ySDSequence ySDSequence, Ac4ySDSequenceEntityMethods ySDSequenceEntityMethods)
        {
            string xml = "";

            XmlSerializer serializer = new XmlSerializer(typeof(Ac4ySDSequence));
            StringWriter stringWriter = new StringWriter();
            XmlWriter xmlWriter = XmlWriter.Create(stringWriter);

            serializer.Serialize(xmlWriter, ySDSequence);

            xml = stringWriter.ToString();

            ySDSequence.serialization = xml;

            ySDSequenceEntityMethods.addNew(ySDSequence);
        }

    }
}
