using System;
using System.IO;
using System.Xml;

namespace EjemplosXml
{
    class Program
    {
        static void Main(string[] args)
        {
            EjemploLeerArchivoYMostrarContenido();
        }


        public static void EjemploLeerArchivoYMostrarContenido()
        {
            XmlDocument xmlDoc = new XmlDocument(); //Creamos un documento XML en memoria
            xmlDoc.Load(File.Open("notasNov30.xml",FileMode.Open)); //Cargamos el contenido de notasNov30.xml

            XmlNodeList nodeList = xmlDoc.DocumentElement.ChildNodes;//Obtenemos todos los nodos hijo
                                                                     //incluidos en el nodo padre de notasNov30.xml
                                                                     //y los guardamos en la variable nodeList
            foreach(XmlNode node in nodeList)//Iteramos a los largo de la lista de nodos nodeList para obtener
            {                                // su texto interno
                Console.WriteLine(node.InnerText); //Imprimimos el contenido del nodo
            }

            
            Console.ReadKey();
        }

        public static void EjemploCrearArchivo()
        {
            //CREAR DOCUMENTO EN MEMORIA
            XmlDocument xmlDoc = new XmlDocument(); //Creamos un documento XML en memoria
            xmlDoc.LoadXml("<notasPadre></notasPadre>");//Le asignamos nuevo nodo Padre a nuestro nuevo documento

            


            //MODIFICAR DOCUMENTO EN MEMORIA
            //Agregar un nodo hijo a el nodo padre del documento
            XmlElement newElement = xmlDoc.CreateElement("nota");
            newElement.InnerText = "Esta es una nota de prueba";
            xmlDoc.DocumentElement.AppendChild(newElement);

            //Agregar otro nodo hijo
            XmlElement newElement2 = xmlDoc.CreateElement("nota");
            newElement2.InnerText = "Esta es la segunda nota de prueba";
            xmlDoc.DocumentElement.AppendChild(newElement2);

            //CREAR ARCHIVO FISICAMENTE
            XmlWriterSettings settings = new XmlWriterSettings();//Objeto con configuracion de Writer
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(File.Create("notas.xml"),settings); //Creamos writer utilizando configuracion

            //Guardamos el documento físicamente
            xmlDoc.Save(writer);

        }
    }
}
