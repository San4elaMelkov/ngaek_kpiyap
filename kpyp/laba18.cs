using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace kpyp
{
    class laba18
    {
        public static void print()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../../laba18.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            // создаем новый элемент user
            XmlElement studentElem = xDoc.CreateElement("student");
            // создаем атрибут name
            XmlAttribute nameAttr = xDoc.CreateAttribute("name");

            XmlElement nameElem = xDoc.CreateElement("name");
            XmlElement surnameElem = xDoc.CreateElement("surname");
            XmlElement dateElem = xDoc.CreateElement("date");
            // создаем текстовые значения для элементов и атрибута
            Console.WriteLine("Введите Имя");
            XmlText nameText = xDoc.CreateTextNode(Console.ReadLine());
            Console.WriteLine("Введите Фамилию");
            XmlText surnameText = xDoc.CreateTextNode(Console.ReadLine());
            Console.WriteLine("Введите Дату рождения");
            XmlText dateText = xDoc.CreateTextNode(Console.ReadLine());

            //добавляем узлы
            nameAttr.AppendChild(nameText);
            nameElem.AppendChild(nameText);
            surnameElem.AppendChild(surnameText);
            dateElem.AppendChild(dateText);

            studentElem.Attributes.Append(nameAttr);
            studentElem.AppendChild(nameElem);
            studentElem.AppendChild(surnameElem);
            studentElem.AppendChild(dateElem);
            xRoot.AppendChild(studentElem);
            
            Console.WriteLine("Файл заполнен");
            XmlNode firstNode = xRoot.FirstChild;
            xRoot.RemoveChild(firstNode);
            xDoc.Save("../../../laba18.xml");
        }
    }
}
