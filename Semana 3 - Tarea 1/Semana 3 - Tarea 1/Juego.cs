using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3___Tarea_1
{
    public class Juego
    {
        private Jugador jugador;
        private List<Enemigo> enemigos;

        public Juego(Jugador jugador, List<Enemigo> enemigos)
        {
            this.jugador = jugador;
            this.enemigos = enemigos;
        }

        public void Jugar()
        {
            while (jugador.Vida > 0 && HayEnemigosVivos())
            {
                Console.WriteLine("\nTurno del jugador:");
                AtacarEnemigo(jugador, enemigos);
                if (!HayEnemigosVivos()) break;

                Console.WriteLine("\nTurno de los enemigos:");
                foreach (var enemigo in enemigos)
                {
                    if (enemigo.EstaVivo())
                    {
                        jugador.RecibirDaño(enemigo.ObtenerDaño());
                        Console.WriteLine($"El enemigo causa {enemigo.ObtenerDaño()} de daño al jugador.");
                        break;
                    }
                }
            }

            if (jugador.Vida <= 0)
                Console.WriteLine("\n¡Has sido derrotado!");
            else
                Console.WriteLine("\n¡Has ganado!");
        }

        private void AtacarEnemigo(Jugador jugador, List<Enemigo> enemigos)
        {
            Console.WriteLine("Selecciona un enemigo para atacar:");
            for (int i = 0; i < enemigos.Count; i++)
            {
                if (enemigos[i].EstaVivo())
                    Console.WriteLine($"{i + 1}. Enemigo {(i + 1)}");
            }

            int seleccion;
            do
            {
                Console.Write("Selecciona un enemigo válido: ");
            } while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > enemigos.Count || !enemigos[seleccion - 1].EstaVivo());

            enemigos[seleccion - 1].RecibirDaño(jugador.ObtenerDaño());
            Console.WriteLine($"El jugador causa {jugador.ObtenerDaño()} de daño al enemigo {seleccion}.");
        }

        private bool HayEnemigosVivos()
        {
            foreach (var enemigo in enemigos)
            {
                if (enemigo.EstaVivo())
                    return true;
            }
            return false;
        }
    }
}
