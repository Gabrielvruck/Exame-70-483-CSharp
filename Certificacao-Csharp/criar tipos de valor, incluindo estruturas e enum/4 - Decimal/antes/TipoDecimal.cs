using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificacao_Csharp.criar_tipos_de_valor__incluindo_estruturas_e_enum._4___Decimal.antes
{
    public class TipoDecimal : IAulaItem
    {
        public void Executar()
        {
            double valorProduto1 = 10;
            double valorProduto2 = 20;
            double subtotal = 30;

            Console.WriteLine("Descobrindo se 10 + 20 == 30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);

            //______________________________________________________________
            //______________________________________________________________

            valorProduto1 = 10.10;
            valorProduto2 = 20.20;
            subtotal = 30.30;

            Console.WriteLine("Descobrindo se 10.10 + 20.20 == 30.30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);

            //______________________________________________________________
            Console.WriteLine(valorProduto1 + valorProduto2);
            //______________________________________________________________

            Console.WriteLine("Descobrindo se (10.1 + 20.2) == 30.299999999999997");
            Console.WriteLine((valorProduto1 + valorProduto2) == 30.299999999999997);

            //______________________________________________________________
            //______________________________________________________________

            decimal materiaPrima = 10.1m;
            decimal maoDeObra = 20.2m;
            decimal custo = 30.3m;

            Console.WriteLine("Descobrindo se (10.1m + 20.2m) == 30.3m");
            Console.WriteLine((materiaPrima + maoDeObra) == custo);
        }
    }
}
