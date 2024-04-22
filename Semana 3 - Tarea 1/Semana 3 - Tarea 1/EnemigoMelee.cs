using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3___Tarea_1
{
    public class EnemigoMelee : Enemigo
    {
        public EnemigoMelee(int vida, int daño) : base(vida, daño) { }

        public override bool EstaVivo()
        {
            return Vida > 0;
        }
    }
}
