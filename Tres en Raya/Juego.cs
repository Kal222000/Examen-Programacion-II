using System;

public class Juego
{
    private Jugador[] fila1;
    private Jugador[] fila2;
    private Jugador[] fila3;
    private Jugador[] lista_jugadores;
    private int cantidad_turnos;

    public Juego()
    {
        this.fila1 = new Jugador[3];
        this.fila2 = new Jugador[3];
        this.fila3 = new Jugador[3];
        this.lista_jugadores = new Jugador[2];
        this.cantidad_turnos = 0;
    }

    public void mostrar_tablero()
    {
        for(int i = 1; i <= 3; i++)
        {
            if(i == 1)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.fila1[j] == null && j < 2)
                    {
                        Console.Write("   |");
                    }
                    else if(this.fila1[j] != null && j < 2)
                    {
                        Console.Write(" " + this.fila1[j].get_signo() + " |");
                    }
                    else if (this.fila1[j] == null)
                    {
                        Console.WriteLine("   ");
                    }
                    else
                    {
                        Console.WriteLine(" " + this.fila1[j].get_signo() + " ");
                    }
                }
                Console.WriteLine("------------");

             }
            else if(i == 2)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.fila2[j] == null && j < 2)
                    {
                        Console.Write("   |");
                    }
                    else if (this.fila1[j] != null && j < 2)
                    {
                        Console.Write(" " + this.fila1[j].get_signo() + " |");
                    }
                    else if (this.fila2[j] == null)
                    {
                        Console.WriteLine("   ");
                    }
                    else
                    {
                        Console.WriteLine(" " + this.fila1[j].get_signo() + " ");
                    }
                }
                Console.WriteLine("------------");
            }
            else if (i == 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.fila3[j] == null && j < 2)
                    {
                        Console.Write("   |");
                    }
                    else if (this.fila1[j] != null && j < 2)
                    {
                        Console.Write(" " + this.fila1[j].get_signo() + " |");
                    }
                    else if (this.fila3[j] == null)
                    {
                        Console.WriteLine("   ");
                    }
                    else
                    {
                        Console.WriteLine(" " + this.fila1[j].get_signo() + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    public void asignacion_signo()
    {
        int[] ubicacion = this.lista_jugadores[(this.cantidad_turnos % 2)].Elegir_ubicación();
        if (ubicacion[0] < 1 || ubicacion[0] > 3)
        {
            asignacion_signo();
        }
        else if (ubicacion[1] < 1 || ubicacion[1] > 3)
        {
            asignacion_signo();
        }
        if (1 == ubicacion[0])
        {
            for (int j = 0; j < 3; j++)
            {
                if (j == ubicacion[1] - 1)
                {
                    if (this.fila1[j] == null)
                    {
                        this.fila1[j] = this.lista_jugadores[(this.cantidad_turnos % 2)];
                    }
                    else
                    {
                        Console.WriteLine("Casilla Ocupada, Ingrese otra casillas");
                        asignacion_signo();
                    }
                }
            }

        }
        else if (2 == ubicacion[0])
        {
            for (int j = 0; j < 3; j++)
            {
                if (j == ubicacion[1] - 1)
                {
                    if (this.fila2[j] == null)
                    {
                        this.fila2[j] = this.lista_jugadores[(this.cantidad_turnos % 2)];
                    }
                    else
                    {
                        Console.WriteLine("Casilla Ocupada, Ingrese otra casillas");
                        asignacion_signo();
                    }
                }
            }
        }
        else if (3 == ubicacion[0])
        {
            for (int j = 0; j < 3; j++)
            {
                if (j == ubicacion[1] - 1)
                {
                    if (this.fila3[j] == null)
                    {
                        this.fila3[j] = this.lista_jugadores[(this.cantidad_turnos % 2)];
                    }
                    else
                    {
                        Console.WriteLine("Casilla ocupada, Ingrese otra casillas");
                        asignacion_signo();
                    }
                }
            }
        }
    }

    public void agregar_jugador(int n, Jugador l)
    {
        this.lista_jugadores[n] = l;
    }

    public void aumentar_turno()
    {
        this.cantidad_turnos++;
    }

    public bool estado()
    {
        if(this.cantidad_turnos < 9)
        {
            bool estado1 = comprobar();
            if(estado1 == false)
            {
                mostrar_tablero();
                Console.WriteLine("Ganador es" + this.lista_jugadores[(this.cantidad_turnos % 2)].get_signo());
                return estado1;
            }
            else
            {
                return estado1;
            }
        }
        else
        {
            bool estado1 = comprobar();
            if (estado1 == false)
            {
                mostrar_tablero();
                Console.WriteLine("Ganador es " + this.lista_jugadores[(this.cantidad_turnos % 2)].get_signo());
                return estado1;
            }
            else
            {
                mostrar_tablero();
                Console.WriteLine("Empate");
                return false;
            }
        }
    }

    public bool comprobar()
    {
        if (fila1[0] != null && fila1[1] != null && fila1[2] != null)
        {
            if (fila1[0].get_signo() == fila1[1].get_signo() && fila1[0].get_signo() == fila1[2].get_signo())
            {
                return false;
            }
        }

        if (fila2[0] != null && fila2[1] != null && fila2[2] != null)
        {
            if (fila2[0].get_signo() == fila2[1].get_signo() && fila2[0].get_signo() == fila2[2].get_signo())
            {
                return false;
            }
        }

        if (fila3[0] != null && fila3[1] != null && fila3[2] != null)
        {
            if (fila3[0].get_signo() == fila3[1].get_signo() && fila3[0].get_signo() == fila3[2].get_signo())
            {
                return false;
            }
        }

        if (fila1[0] != null && fila2[0] != null && fila3[0] != null)
        {
            if (fila1[0].get_signo() == fila2[0].get_signo() && fila1[0].get_signo() == fila3[0].get_signo())
            {
                return false;
            }
        }

        if (fila1[1] != null && fila2[1] != null && fila3[1] != null)
        {
            if (fila1[1].get_signo() == fila2[1].get_signo() && fila1[1].get_signo() == fila3[1].get_signo())
            {
                return false;
            }
        }

        if (fila1[2] != null && fila2[2] != null && fila3[2] != null)
        {
            if (fila1[2].get_signo() == fila2[2].get_signo() && fila1[2].get_signo() == fila3[2].get_signo())
            {
                return false;
            }
        }

        if (fila1[0] != null && fila2[1] != null && fila3[2] != null)
        {
            if (fila1[0].get_signo() == fila2[1].get_signo() && fila1[0].get_signo() == fila3[2].get_signo())
            {
                return false;
            }
        }

        if (fila1[2] != null && fila2[1] != null && fila3[0] != null)
        {
            if (fila1[2].get_signo() == fila2[1].get_signo() && fila1[2].get_signo() == fila3[0].get_signo())
            {
                return false;
            }
        }

        return true;
    }
}
