using Semana_3___Tarea_1;

class Program
{
    static void Main(string[] args)
    {
        Jugador jugador = CrearJugador();
        List<Enemigo> enemigos = CrearEnemigos();

        Juego juego = new Juego(jugador, enemigos);
        juego.Jugar();
    }

    static Jugador CrearJugador()
    {
        Console.WriteLine("Crea tu jugador:");
        Console.Write("Ingrese la vida del jugador: ");
        int vidaJugador;
        while (!int.TryParse(Console.ReadLine(), out vidaJugador) || vidaJugador <= 0 || vidaJugador > 100)
        {
            Console.Write("Ingrese una cantidad válida (1-100): ");
        }

        Console.Write("Ingrese el daño del jugador: ");
        int dañoJugador;
        while (!int.TryParse(Console.ReadLine(), out dañoJugador) || dañoJugador <= 0 || dañoJugador > 100)
        {
            Console.Write("Ingrese una cantidad válida (1-100): ");
        }

        return new Jugador(vidaJugador, dañoJugador);
    }

    static List<Enemigo> CrearEnemigos()
    {
        List<Enemigo> enemigos = new List<Enemigo>();

        enemigos.Add(new EnemigoMelee(50, 10));
        enemigos.Add(new EnemigoMelee(60, 15));
        enemigos.Add(new EnemigoRango(40, 8, 3));
        enemigos.Add(new EnemigoRango(30, 12, 2));

        return enemigos;
    }
}