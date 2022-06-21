using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Distribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] dia = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
            double[] valor = { 31490.7866, 37277.9400, 37708.4303, 0.0000, 0.0000, 17934.2269, 0.0000, 6965.1262, 24390.9374, 14279.6481, 0.0000, 0.0000, 39807.6622, 27261.6304, 39775.6434, 29797.6232, 17216.5017, 0.0000, 0.0000, 12974.2000, 28490.9861, 8748.0937, 8889.0023, 17767.5583, 0.0000, 0.0000, 3071.3283, 48275.2994, 10299.6761, 39874.1073 };
            double menor = valor[0], maior = valor[0], media = 0;
            int dia_menor = 0, dia_maior = 0, num_dia = 0, dia_media = 0;

            for (int i = 0; i < 30; i++)
            {
                if (valor[i] != 0)
                {
                    media += valor[i];
                    dia_media++;
                }
            }
            media = media / dia_media;

            for (int i = 0; i < 30; i++)
            {
                if (valor[i] < menor && valor[i] != 0)
                {
                    menor = valor[i];
                    dia_menor = i + 1;
                }
                else if (valor[i] > maior)
                {
                    maior = valor[i];
                    dia_maior = i + 1;
                }

                if (valor[i] > media)
                {
                    num_dia++;
                }
            }

            Console.WriteLine($"O menor valor de faturamento ocorrido em um dia do mês foi {menor} no dia {dia_menor}!");
            Console.WriteLine($"O maior valor de faturamento ocorrido em um dia do mês foi {maior} no dia {dia_maior}!");
            Console.WriteLine($"O Número de dias no mês em que o valor de faturamento diário foi superior à média mensal foi de {num_dia} dias!");
        }
    }
}