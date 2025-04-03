Juego juego1 = new Juego();
Console.WriteLine("Ingrese 1 si desea que su signo sea X, 2 si desea que su signo sea O");
string l = Console.ReadLine();
if (l[0] == '1')
{
    Jugador jugador1 = new Jugador("X");
    Jugador jugador2 = new Jugador("O");
    juego1.agregar_jugador(0, jugador1);
    juego1.agregar_jugador(1, jugador2);
}
else
{
    Jugador jugador1 = new Jugador("O");
    Jugador jugador2 = new Jugador("X");
    juego1.agregar_jugador(0, jugador1);
    juego1.agregar_jugador(1, jugador2);
}
Console.WriteLine("Cuando inserte los datos de fila y columna, debe estar dentro del rango 1-3");
bool estado = true;
while (estado)
    {
        juego1.mostrar_tablero();
        juego1.asignacion_signo();
        estado = juego1.estado();
        juego1.aumentar_turno();
        Console.WriteLine();
    }
