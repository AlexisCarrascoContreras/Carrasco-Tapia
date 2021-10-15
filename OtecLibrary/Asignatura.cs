﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OtecLibrary
{
    public class Asignatura
    {
        private int id;
        private string nombre;

        public Asignatura()
        {

        }

        public Asignatura(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
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
