using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificacao_Csharp.criar_tipos_de_valor__incluindo_estruturas_e_enum._2__Tipos_Inteiros.antes
{
    public class TipoDeInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15; /*System.Int32*/
            //idade = 15.5;
            char resposta = 'S'; /*System.Char*/
            byte nivelDeAzul = 0xff; /*byte contem 8 bytes*/
            //nivelDeAzul = -3
            short passageirosVoo = 230; /*System.Int16 = apresenta 2 bytes*/
            passageirosVoo = -7;
            int populacao = 1500; /*System.Int32*/
            populacao = -2500;
            long populacaoDoBrasil = 207_660_929; /*+/- 207 milhoes -  System.Int64*/
            sbyte nivelDeBrilho = -127;/* System.sbyte*/
            //não aceita negativo
            ushort passageirosNavio = 230;/* System.uint16*/
            //não aceita negativo
            uint estoque = 1500; /*System.UInt32*/
            //não aceita negativo
            ulong populacaoDoMundo = 7_000_000_000; /* 7 bilhoes -  System.Int64*/

            Console.WriteLine($"resposta: {resposta}");
            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");
            Console.WriteLine($"niveldeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");
        }
    }
}
