﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaDesconto
    {
    }
}
namespace Model
{
    public class CalculaDesconto
    {
        // Método estático para calcular o valor com desconto
        public static double Calcular(double valor, double desconto)
        {
            return valor - desconto;
        }
    }
}

