using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3___Tarea_1
{
    public class Jugador
    {
        public int Vida { get; set; }
        public int Daño { get; }

        public Jugador(int vida, int daño)
        {
            Vida = vida;
            Daño = daño;
        }

        public void RecibirDaño(int dañoRecibido)
        {
            Vida -= dañoRecibido;
        }

        public int ObtenerDaño()
        {
            return Daño;
        }
    }
}
