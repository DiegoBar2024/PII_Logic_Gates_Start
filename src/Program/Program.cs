namespace Program;
using Ucu.Poo.Gates;

class Program
{
    static void Main(string[] args)
    {
        // Creamos la compuerta AND-1 y sus entradas
        CompuertaAND and1 = new CompuertaAND("AND-1");
        and1.AgregarEntrada("A",0);
        and1.AgregarEntrada("B",1);
        Console.WriteLine($"Resultado intermedio compuerta '{and1.GetNombre()}': {and1.Calcular()}");

        // Creamos la compuerta OR
        CompuertaOR or2 = new CompuertaOR("OR-2");
        or2.AgregarEntrada("C",0);
        or2.AgregarEntrada(and1.GetNombre(),and1.Calcular());
        Console.WriteLine($"Resultado intermedio compuerta {or2.GetNombre()}: {or2.Calcular()}");

        // Y la compuerta NOT
        CompuertaNOT not3 = new CompuertaNOT("NOT-3");
        not3.AgregarEntrada(or2.GetNombre(),or2.Calcular());

        // Resultado final
        Console.WriteLine($"Resultado final: {not3.Calcular()}");
    }
}
