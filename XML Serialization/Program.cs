using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;

namespace XML_Serialization;

class Program
{
    static void Main(string[] args)
    {
        //My Object to serialize
        Person personOne = new("Lucas", 19);

        #region Setting up DataContractSerializer
        // Creating a XML DataContract of class Person
        DataContractSerializer xmlSerializer = new DataContractSerializer(typeof(Person));

        //My StringBuilder which will contain my XML text
        StringBuilder personObject = new();
        #endregion

        #region Serialize
        // Configurating XML Writer Settings
        XmlWriterSettings xmlSettings = new XmlWriterSettings() { Indent = true };

        //Serializing
        using (XmlWriter xmlWriter = XmlWriter.Create(personObject, xmlSettings))
        {
            xmlSerializer.WriteObject(xmlWriter, personOne);
        }
        #endregion

        #region Saving the content in a XML File

        /*Creating my XML File*/
        string path = @"person.xml";
        FileStream myXml = File.Create(path);
        myXml.Close();

        /*Writing in my XML File*/
        File.WriteAllText(path, personObject.ToString());

        #endregion

        #region Deserialize
        //Creating my string to save XML Content
        string xmlText = File.ReadAllText(path);
        StringReader stringReader = new StringReader(xmlText);

        //Deserializing
        using (XmlReader xmlReader = XmlReader.Create(stringReader))
        {
            Person personDeserialized = (Person)xmlSerializer.ReadObject(xmlReader);
        }
        #endregion
    }
}
