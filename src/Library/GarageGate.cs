using System;

namespace Ucu.Poo.Gates
{
    // Creo una clase GarageGate la cual implementa la interfaz IGate
    public class GarageGate : IGate
    {
        // Atributos de la clase
        public string Nombre { get; set; }
        public Dictionary<string, int> Entradas { get; set; }

        // Constructor de la clase
        public GarageGate(string nombre)
        {
            this.Nombre = nombre;
            this.Entradas = new Dictionary<string,int>();
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
            // Creación de compuertas AND
            CompuertaAND and1 = new CompuertaAND("and1");
            CompuertaAND and2 = new CompuertaAND("and2");
            CompuertaAND and3 = new CompuertaAND("and3");

            // Creación de compuerta OR
            CompuertaOR or = new CompuertaOR("or");

            // Creación de compuertas NOT
            CompuertaNOT not1 = new CompuertaNOT("not1");
            CompuertaNOT not2 = new CompuertaNOT("not2");

            // Operación AND1
            and1.AgregarEntrada("a",this.Entradas["a"]);
            and1.AgregarEntrada("b",this.Entradas["b"]);

            // Operación NOT1
            not1.AgregarEntrada("b",this.Entradas["b"]);

            // Operación NOT2
            not2.AgregarEntrada("a",this.Entradas["a"]);

            // Operación AND2
            and2.AgregarEntrada(not1.GetNombre(),not1.Calcular());
            and2.AgregarEntrada(not2.GetNombre(),not2.Calcular());

            // Operación OR
            or.AgregarEntrada(and1.GetNombre(),and1.Calcular());
            or.AgregarEntrada(and2.GetNombre(),and2.Calcular());

            // Operación AND3
            and3.AgregarEntrada(or.GetNombre(),or.Calcular());
            and3.AgregarEntrada("c",this.Entradas["c"]);

            // Retorno el valor lógico correspondiente
            return and3.Calcular();
        }
    }
}