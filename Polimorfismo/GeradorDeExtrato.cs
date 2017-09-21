using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class GeradorDeExtrato
    {
        public void ImprimeExtratoBasico(Conta c)
        {
            DateTime agora = DateTime.Now;
            string horario = string.Format("{0:d/M/yyyy HH:mm:ss}", agora);

            Console.WriteLine("DATA: {0:c}", horario);
            Console.WriteLine("SALDO: {0:c}", c.Saldo);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
