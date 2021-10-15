using System;
using System.Collections.Generic;
using System.Text;

namespace OtecLibrary
{
    public class Sede
    {
        private int id;
        private string nombre;
        private string administrador;

        public Sede()
        {

        }

        public Sede(int id, string nombre, string administrador)
        {
            this.id = id;
            this.nombre = nombre;
            this.administrador = administrador;

        }


        public string Administrador
        {
            get { return administrador; }
            set { administrador = value; }
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
