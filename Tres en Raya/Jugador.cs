using System;

public class Jugador
{
	private string signo;
	private int cantidad_movimientos;

	public Jugador(string signo)
	{
		this.signo = signo;
		this.cantidad_movimientos = 0;
	}

	public int[] Elegir_ubicación()
	{
		int[] ubicacion = new int[2];
        Console.WriteLine("Inserte la fila");
		int fila = int.Parse(Console.ReadLine());
		ubicacion[0] = fila;
        Console.WriteLine("Inserte la columna");
        int columna = int.Parse(Console.ReadLine());
        ubicacion[1] = columna;
		return ubicacion;
    }

	public string get_signo()
	{
		return this.signo;
	}
}
