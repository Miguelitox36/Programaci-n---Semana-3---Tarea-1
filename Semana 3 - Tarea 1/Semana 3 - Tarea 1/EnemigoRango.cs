using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3___Tarea_1
{
    public class EnemigoRango : Enemigo
    {
        private int balasRestantes;

        public EnemigoRango(int vida, int daño, int balas) : base(vida, daño)
        {
            balasRestantes = balas;
        }

        public override void RecibirDaño(int dañoRecibido)
        {
            Vida -= dañoRecibido;
            if (Vida < 0)
                Vida = 0;
        }

        public override bool EstaVivo()
        {
            return Vida > 0 && balasRestantes > 0;
        }

        public void PasarTurno()
        {
            balasRestantes--;
        }
    }
}
