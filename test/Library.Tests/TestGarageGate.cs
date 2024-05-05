using Ucu.Poo.Gates;

namespace Library.Tests;

public class TestGarageGate
{
    [Test]
    public void TablaVerdadGarageGate()
    {
        // Creo un objeto GarageGate
        GarageGate garageGate = new GarageGate("GarageGate");

        // Caso a = 0, b = 0, c = 0
        garageGate.AgregarEntrada("a",0);
        garageGate.AgregarEntrada("b",0);
        garageGate.AgregarEntrada("c",0);

        // Compruebo que la operación sea correcta
        Assert.AreEqual(0,garageGate.Calcular());

        // Caso a = 1, b = 0, c = 0
        garageGate.AgregarEntrada("a",1);
        garageGate.AgregarEntrada("b",0);
        garageGate.AgregarEntrada("c",0);

        // Compruebo que la operación sea correcta
        Assert.AreEqual(0,garageGate.Calcular());

        // Caso a = 0, b = 1, c = 0
        garageGate.AgregarEntrada("a",0);
        garageGate.AgregarEntrada("b",1);
        garageGate.AgregarEntrada("c",0);

        // Compruebo que la operación sea correcta
        Assert.AreEqual(0,garageGate.Calcular());
        
        // Caso a = 1, b = 1, c = 0
        garageGate.AgregarEntrada("a",1);
        garageGate.AgregarEntrada("b",1);
        garageGate.AgregarEntrada("c",0);

        // Compruebo que la operación sea correcta
        Assert.AreEqual(0,garageGate.Calcular());

        // Caso a = 0, b = 0, c = 1
        garageGate.AgregarEntrada("a",0);
        garageGate.AgregarEntrada("b",0);
        garageGate.AgregarEntrada("c",1);

        // Compruebo que la operación sea correcta
        Assert.AreEqual(1,garageGate.Calcular());

        // Caso a = 1, b = 0, c = 1
        garageGate.AgregarEntrada("a",1);
        garageGate.AgregarEntrada("b",0);
        garageGate.AgregarEntrada("c",1);

        // Compruebo que la operación sea correcta
        Assert.AreEqual(0,garageGate.Calcular());
        
        // Caso a = 0, b = 1, c = 1
        garageGate.AgregarEntrada("a",0);
        garageGate.AgregarEntrada("b",1);
        garageGate.AgregarEntrada("c",1);

        // Compruebo que la operación sea correcta
        Assert.AreEqual(0,garageGate.Calcular());

        // Caso a = 1, b = 1, c = 1
        garageGate.AgregarEntrada("a",1);
        garageGate.AgregarEntrada("b",1);
        garageGate.AgregarEntrada("c",1);

        // Compruebo que la operación sea correcta
        Assert.AreEqual(1,garageGate.Calcular());
    }
}