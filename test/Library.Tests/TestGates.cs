using Ucu.Poo.Gates;

namespace Library.Tests;

public class Tests
{
    [Test]
    public void TestTablaVerdadAND()
    {
        // Creo un objeto compuertaAND
        CompuertaAND and = new CompuertaAND("and");

        // Caso 1: A = 0 y B = 0
        and.AgregarEntrada("A",0);
        and.AgregarEntrada("B",0);

        // Compruebo que el cálculo es igual al esperado
        Assert.AreEqual(and.Calcular(),0);

        // Caso 2: A = 0 y B = 1
        and.AgregarEntrada("A",0);
        and.AgregarEntrada("B",1);

        // Compruebo que el cálculo es igual al esperado
        Assert.AreEqual(and.Calcular(),0);

        // Caso 3: A = 1 y B = 0
        and.AgregarEntrada("A",1);
        and.AgregarEntrada("B",0);

        // Compruebo que el cálculo es igual al esperado
        Assert.AreEqual(and.Calcular(),0);

        // Caso 4: A = 1 y B = 1
        and.AgregarEntrada("A",1);
        and.AgregarEntrada("B",1);

        // Compruebo que el cálculo es igual al esperado
        Assert.AreEqual(and.Calcular(),1);
    }

    [Test]
    public void TestTablaVerdadOR()
    {
        // Creo un objeto compuertaOR
        CompuertaOR or = new CompuertaOR("or");

        // Caso 1: A = 0 y B = 0
        or.AgregarEntrada("A",0);
        or.AgregarEntrada("B",0);

        // Compruebo que el cálculo es igual al esperado
        Assert.AreEqual(or.Calcular(),0);

        // Caso 2: A = 0 y B = 1
        or.AgregarEntrada("A",0);
        or.AgregarEntrada("B",1);

        // Compruebo que el cálculo es igual al esperado
        Assert.AreEqual(or.Calcular(),1);

        // Caso 3: A = 1 y B = 0
        or.AgregarEntrada("A",1);
        or.AgregarEntrada("B",0);

        // Compruebo que el cálculo es igual al esperado
        Assert.AreEqual(or.Calcular(),1);

        // Caso 3: A = 1 y B = 1
        or.AgregarEntrada("A",1);
        or.AgregarEntrada("B",1);

        // Compruebo que el cálculo es igual al esperado
        Assert.AreEqual(or.Calcular(),1);
    }

    [Test]
    public void TestTablaVerdadNOT()
    {
        // Creo un objeto compuertaNOT
        CompuertaNOT not = new CompuertaNOT("not");

        // Caso 1: A = 0
        not.AgregarEntrada("A",0);

        // Compruebo que el cálculo es igual al esperado
        Assert.AreEqual(not.Calcular(),1);

        // Caso 2: A = 1
        not.AgregarEntrada("A",1);

        // Compruebo que el cálculo es igual al esperado
        Assert.AreEqual(not.Calcular(),0);
    }
}