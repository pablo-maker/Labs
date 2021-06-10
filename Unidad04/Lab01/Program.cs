using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FileStream lector = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            while (lector.Length > lector.Position)
            {
                Console.Write((char)lector.ReadByte());
            }
            */

            /*leer();
            Console.ReadKey();
            escribir();
            Console.ReadKey();
            leer();
            Console.ReadKey();
            */

            Console.WriteLine("Presione una tecla para generar el archivo agendaxml.xml con los datos de agenda.txt");
            Console.ReadKey();
            EscribirXML();
            Console.WriteLine("Archivo agendaxml.xml generado correctamente \n\nPresione una tecla para ver su contenido");
            Console.ReadKey();
            Console.WriteLine();
            LeerXML();
            Console.ReadKey();

        }

        private static void leer()
        {
            StreamReader lector = File.OpenText("agenda.txt");
            string linea;
            Console.WriteLine("Nombre\tApellido\te-mail\t\t\tTelefono");
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
                }
            } while (linea != null);
            lector.Close();
        }

        private static void escribir()
        {
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese un nuevo contacto:");
            string rta = "S";
            while (rta == "S")
            {
                Console.WriteLine("Ingrese Nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese Apellido:");
                string apellido = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese E-mail:");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese Telefono:");
                string telefono = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);

                Console.WriteLine("¿Desea agregar otro contacto? (S/N)");
                rta = Console.ReadLine();
            }
            escritor.Close();
        }
        private static void EscribirXML()
        {
            XmlTextWriter escritorXML = new XmlTextWriter("agendaxml.xml", null);
            escritorXML.Formatting = Formatting.Indented; //para hacer mas facil la lectura del archivo
            escritorXML.WriteStartDocument(true);
            escritorXML.WriteStartElement("DocumentElement");//compatibilidad para proximos labs
            StreamReader lector = File.OpenText("agenda.txt");
            string linea;
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    escritorXML.WriteStartElement("contactos");
                    escritorXML.WriteStartElement("nombre");
                    escritorXML.WriteValue(valores[0]);
                    escritorXML.WriteEndElement(); //cierra el tag nombre
                    escritorXML.WriteStartElement("apellido");
                    escritorXML.WriteValue(valores[1]);
                    escritorXML.WriteEndElement(); //cierra el tag apellido
                    escritorXML.WriteStartElement("email");
                    escritorXML.WriteValue(valores[2]);
                    escritorXML.WriteEndElement(); //cierra el tag email
                    escritorXML.WriteStartElement("telefono");
                    escritorXML.WriteValue(valores[3]);
                    escritorXML.WriteEndElement(); //cierra el tag telefono
                    escritorXML.WriteEndElement(); //cierra el tag contactos
                }
            } while (linea != null);
            escritorXML.WriteEndElement(); //cierra el tag DocumentElement
            escritorXML.WriteEndDocument();

            escritorXML.Close();

            lector.Close();


        }
        private static void LeerXML()
        {
            XmlTextReader lectorXML = new XmlTextReader("agenda.txt");
            string tagAnterior = "";
            while (lectorXML.Read())
            {
                if (lectorXML.NodeType == XmlNodeType.Element)
                {
                    tagAnterior = lectorXML.Name;
                }
                else if (lectorXML.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(tagAnterior + ": " + lectorXML.Value);
                }
            }
            lectorXML.Close();
        }
        
    }
}
