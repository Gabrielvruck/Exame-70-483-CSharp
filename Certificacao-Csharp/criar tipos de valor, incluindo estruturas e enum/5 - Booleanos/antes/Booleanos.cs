using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificacao_Csharp.criar_tipos_de_valor__incluindo_estruturas_e_enum._5___Booleanos.antes
{
    public class Booleanos : IAulaItem
    {
        public void Executar()
        {
            //bool possuiSaldo = 1;
            bool possuiSaldo = true;

            Console.WriteLine($"possuiSaldo: {possuiSaldo}");
            //________________________________________________
            int dias = DateTime.Now.Day;
            Console.WriteLine($"dias: {dias}");
            //______________________________________

            //Atribui a diasPar o valor de uma expressão booleana
            bool diasPar = (dias % 2 == 0);

            if (diasPar)
            {
                Console.WriteLine("dias é um número par");
            }
            else
            {
                Console.WriteLine("dias é um número ímpar");
            }
        }
    }
}
