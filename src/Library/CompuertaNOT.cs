using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ucu.Poo.Gates
{
    public class CompuertaNOT : IGate
    {
        // Atributos de la clase
        public string Nombre { get; set; }
        public string Conector { get; set; }
        public int Valor { get; set; }
        public int Salida { get; set; }

        // Constructor de la clase
        public CompuertaNOT(string nombre)
        {
            this.Nombre = nombre;
            this.Conector = "";
            this.Valor = 0;
            this.Salida = 0;
        }

        // Método GetNombre
        public string GetNombre()
        {
            return this.Nombre;
        }

        // Método AgregarEntrada
        public void AgregarEntrada(string conector, int valor)
        {
            this.Conector = conector;
            this.Valor = valor;
        }

        // Método Calcular
        public int Calcular()
        {
            if (this.Valor == 0)
            {
                return 1;
            }

            return 0;
        }

    }
}