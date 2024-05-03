using System;

namespace Ucu.Poo.Gates
{
    // Creo la clase CompuertaOR la cual implementa la interfaz IGate
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
            // En caso que el conector ya exista, lo sustituyo por el nuevo parámetro.
            if (this.Entradas.Keys.Contains(conector))
            {
                this.Entradas[conector] = valor;
            }

            // En caso que el conector no exista, lo creo y le asigno el valor requerido
            else
            {
                this.Entradas.Add(conector,valor);
            }
        }

        // Método Calcular
        public int Calcular()
        {
            // Itero para cada uno de los bits de entrada
            foreach (string entrada in this.Entradas.Keys)
            {
                // En caso que exista un bit igual a 1, digo que me retorne 1
                if (this.Entradas[entrada] == 1)
                {                    
                    return 1;
                }
            }
            return 0;
        }
    }
}