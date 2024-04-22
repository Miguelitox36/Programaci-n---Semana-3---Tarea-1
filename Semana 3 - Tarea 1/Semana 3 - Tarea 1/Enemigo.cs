using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3___Tarea_1
{
    public abstract class Enemigo
    {
        public int Vida { get; protected set; }
        public int Daño { get; }

        public Enemigo(int vida, int daño)
        {
            Vida = vida;
            Daño = daño;
        }

        public virtual void RecibirDaño(int dañoRecibido)
        {
            Vida -= dañoRecibido;
        }

        public int ObtenerDaño()
        {
            return Daño;
        }

        public abstract bool EstaVivo();
    }
}
