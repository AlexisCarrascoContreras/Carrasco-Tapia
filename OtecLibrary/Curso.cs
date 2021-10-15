using System;
using System.Collections.Generic;
using System.Text;



namespace OtecLibrary
{
    public class Curso
    {
        private int id;
        private string nombre;
        private string asignatura;
        private string sede;
       // Coordinador coaordinador = new Coordinador();
        private Coordinador coordinador;

        public Curso()
        {

        }

        public Curso(int id, string nombre, string asignatura, string sede,Coordinador coordinador)
        {
            this.id = id;
            this.nombre = nombre;
            this.asignatura = asignatura;
            this.sede = sede;
            this.coordinador = coordinador;
        }

        public string Sede
        {
            get { return sede; }
            set { sede = value; }
        }

        public string Asignaura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Iid
        {
            get { return id; }
            set { id = value; }
        }

    }
}
