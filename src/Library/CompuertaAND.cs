using System;

namespace Ucu.Poo.Gates
{
    public class CompuertaAND : IGate
    {
        // Atributos de la clase
        public string Nombre { get; set; }
        public Dictionary<string, int> Entradas { get; set; }
        public int Salida { get; set; }

        // Constructor de la clase
        public CompuertaAND(string nombre)
        {
            this.Nombre = nombre;
            this.Entradas = new Dictionary<string, int>();
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
            this.Entradas.Add(conector, valor);
        }

        // Método Calcular
        public int Calcular()
        {
            int prod = 1;

            foreach (string entrada in this.Entradas.Keys)
            {
                prod *= this.Entradas[entrada];
            }

            return prod;
        }

    }
}