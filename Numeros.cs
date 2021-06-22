using System;

class Numeros
{
    int[] datos;
    public Numeros(int[] datos)
    {
        Datos = datos;
    }
    public int[] Solucion()
    {
        Array.Sort(Datos);
        return Datos;
    }
    public int[] Datos { get => datos; set => datos = value; }
}
