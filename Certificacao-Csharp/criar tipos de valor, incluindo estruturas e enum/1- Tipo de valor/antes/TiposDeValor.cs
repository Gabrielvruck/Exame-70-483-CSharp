using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificacao_Csharp.criar_tipos_de_valor__incluindo_estruturas_e_enum._1__Tipo_de_valor.antes
{
    public class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade = 30;
            //imprimir o idade no console.write
            Console.Write(idade);

            System.Int32 copiaIdade = idade;

            Console.Write($"Idade: {idade}");
            Console.Write($"Copia Idade: {copiaIdade}");

            //alteracao no valor da variavel idade
            idade = 23;

            Console.Write($"Idade: {idade}");
            Console.Write($"Copia Idade: {copiaIdade}");

            //Com o ponto de ? significa que aquela variavel aceita nullo
            int? idade2 = null;
        }
    }
}
