using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {
    }
}
namespace Model
{
    public class CalculaAluguelCarro
    {
        // Método estático para calcular o valor do aluguel do carro
        public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            // Valor fixo por dia e por quilômetro rodado
            double valorDiaria = 50.0; // Valor fixo por dia
            double valorPorKm = 0.25;  // Valor fixo por quilômetro rodado

            // Calculando o valor total
            int quilometragemTotal = quilometragemFinal - quilometragemInicial;
            double valorTotal = (dias * valorDiaria) + (quilometragemTotal * valorPorKm);

            return valorTotal;
        }
    }
}

