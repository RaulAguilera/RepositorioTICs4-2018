using System;
using System.IO;
using System.Xml;

namespace EjemplosXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.-Opcion 1");
            Console.WriteLine("2.-Opcion 2");

            string opcion = Console.ReadLine();

            if(opcion == "1")
            {
                EjemploLeerArchivoYMostrarContenido();
            }
            else if(opcion=="2"){
                EjemploCrearArchivo();
            }


            Console.ReadKey();
        }


        public static void EjemploLeerArchivoYMostrarContenido()
        {
            XmlDocument xmlDoc = new XmlDocument(); //Creamos un documento XML en memoria
            xmlDoc.Load(File.Open("notas.xml",FileMode.Open)); //Cargamos el contenido de notasNov30.xml

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
            xmlDoc.Load(File.Open("notas.xml",FileMode.Open));//Le asignamos nuevo nodo Padre a nuestro nuevo documento


            //MODIFICAR DOCUMENTO EN MEMORIA
            //Agregar un nodo hijo a el nodo padre del documento
            XmlElement newElement = xmlDoc.CreateElement("nota");
            Console.WriteLine("Escribe el contenido de la nota 1");
            string contenido = Console.ReadLine();
            newElement.InnerText = contenido;
            xmlDoc.DocumentElement.AppendChild(newElement);

            //Agregar otro nodo hijo
            XmlElement newElement2 = xmlDoc.CreateElement("nota");
            Console.WriteLine("Escribe el contenido de la nota 2");
            string contenido2 = Console.ReadLine();
            newElement2.InnerText = contenido2;
            xmlDoc.DocumentElement.AppendChild(newElement2);

            //CREAR ARCHIVO FISICAMENTE
            XmlWriterSettings settings = new XmlWriterSettings();//Objeto con configuracion de Writer
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(File.Create("notas2.xml"),settings); //Creamos writer utilizando configuracion

            //Guardamos el documento físicamente
            xmlDoc.Save(writer);

        }
    }
}
