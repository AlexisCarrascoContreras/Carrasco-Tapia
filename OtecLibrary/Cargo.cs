using System;
using System.Collections.Generic;
using System.Text;

namespace OtecLibrary
{
    public class Cargo
    {
        private int id;
        private string nombre;
        private string asignatura;

        public Cargo()
        {

        }

        public Cargo(int id, string nombre, string asignatura)
        {
            this.id = id;
            this.nombre = nombre;
            this.asignatura = asignatura;
        }

        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
