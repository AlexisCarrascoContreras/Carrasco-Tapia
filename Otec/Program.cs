using System;
using OtecLibrary;

namespace Otec
{
    public class Program
    {
        static void Main(string[] args)
        {
           

            Sede La = new Sede(1,"Los Angeles");
            Console.WriteLine("Nombre Sede :" +La.Nombre);
            Administrador admin = new Administrador(1, "Alexis Carrasco", "19.984.526-8", 941692191);
            Console.WriteLine("Nombre Encargado :" + admin.Nombre);
            Curso cu = new Curso(1, "Tecnico Analista Programador");
            Console.WriteLine("Nombre curso :" + cu.Nombre);
            Asignatura asi = new Asignatura(1, "Poo");
            Console.WriteLine("Cantidad de Asignaturas :" );
            Coordinador coo = new Coordinador(1, "Juan Tapia", "12.345.678-9", 912345678);
            Console.WriteLine("Nombre Cordinador :" + cu.Nombre);




        }

    }
}

