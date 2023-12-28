using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");
            //Instanciando a la estructura
            Alumno alumno1 = new Alumno();

            //Asignando valor a un campo
            alumno1.Nombre = "LARRYSALSA";
            //Mostrando el valor del campo "nombre"
            Console.WriteLine($"El nombre del alumno es:  {alumno1.Nombre}");

        }
    }
    struct Alumno
    {
        //Campos
        string nombre;
        string apellido;
        double calificacion;
        bool alergias;
        string numeroTelefono;

        //Creamos una propiedad para nombre
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }




    }
}
