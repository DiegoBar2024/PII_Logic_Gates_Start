using System;
using Microsoft.Win32.SafeHandles;

namespace Ucu.Poo.Gates
{
    // Interfaz IGate
    public interface IGate
    {
        // Operación GetNombre
        string GetNombre();

        // Operación AgregarEntrada
        void AgregarEntrada(string conector, int valor);

        // Operación Calcular
        int Calcular();
    }
}