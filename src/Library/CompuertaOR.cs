using System;

namespace Ucu.Poo.Gates
{
    public class CompuertaOR : IGate
    {
        // Atributos de la clase
        public string Nombre { get; set; }
        public Dictionary<string, int> Entradas { get; set; }
        public int Salida { get; set; }

        // Constructor de la clase
        public CompuertaOR(string nombre)
        {
            this.Nombre = nombre;
            this.Entradas = new Dictionary<string,int>();
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
            bool entradasCero = true;

            foreach (string entrada in this.Entradas.Keys)
            {
                if (this.Entradas[entrada] == 1)
                {
                    entradasCero = false;
                    break;
                }
            }

            if (entradasCero)
            {
                return 0;
            }
            
            return 1;
        }

    }
}