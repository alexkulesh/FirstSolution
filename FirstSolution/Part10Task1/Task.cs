using System;
using System.Xml;
using Newtonsoft.Json;

namespace Part10Task1
{   
    
    //Дана переменная string, содержащая в себе текст из xml файла, Например
    //"<root> <title>users storage</title> <user id='1'> <name>Vasya</name>
    //</user> <user id='2'> <name>Kolya</name> </user> </root>" Найти и установить
    //библиотеку, которая преобразует xml в json. Написать программу с использованием
    //библиотеки, которая преобразует этот текст в json-формат и выведет его в консоль.

    public class Task
    {
        private static void Main(string[] args)
        {
            string xmlText =
                "<root> <title>users storage</title> <user id='1'> " +
                "<name>Vasya</name> </user> <user id='2'> " +
                "<name>Kolya</name> </user> </root>";
            XmlDocument doc = new();
            doc.LoadXml(xmlText);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            Console.WriteLine(jsonText);
        }
    }
}