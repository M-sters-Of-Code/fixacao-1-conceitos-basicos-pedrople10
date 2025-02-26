using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAumento
    {
    }
}
namespace Model
{
    public class CalculaAumento
    {
        // Método estático para calcular o salário com aumento
        public static double Calcular(double salario, double aumento)
        {
            return salario + aumento;
        }
    }
}
