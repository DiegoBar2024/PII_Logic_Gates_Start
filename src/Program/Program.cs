namespace Program;
using Ucu.Poo.Gates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        CompuertaAND and1 = new CompuertaAND("AND-1");
        and1.AgregarEntrada("A",1);
        and1.AgregarEntrada("B",1);
        and1.AgregarEntrada("C",1);
        and1.AgregarEntrada("D",1);
        and1.AgregarEntrada("E",1);
        and1.AgregarEntrada("F",0);
        and1.AgregarEntrada("G",1);
        Console.WriteLine($"Resultado compuerta {and1.GetNombre()}:{and1.Calcular()}");
    }
}
