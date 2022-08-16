using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificacao_Csharp.criar_tipos_de_valor__incluindo_estruturas_e_enum._6___Estruturas_Definidas_pelo_Usuário.antes
{
    public class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");
            //_______________________________________________________
            PosicaoGPS posicao1;
            posicao1.Latitude = 13.78;
            posicao1.Longitude = 29.51;
            //_______________________________________________________
            posicao1 = new PosicaoGPS() { Latitude = 13.78, Longitude = 29.51 };
        }
      
    }
    interface IGPS
    {
        bool EstaNoHemisferioNorte();
    }

    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }
        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }
}
