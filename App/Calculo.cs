using System;
using System.Collections.Generic;
using System.Text;

namespace Projetos08.App
{
    internal class Calculo
    {
        public int PrimeiroValor { get; set; }
        public int SegundoValor { get; set; }
        public int TerceiroValor { get; set; }

        public Calculo(int primeirovalor, int segundovalor, int terceirovalor)
        {
            PrimeiroValor = primeirovalor;
            SegundoValor = segundovalor;   
            TerceiroValor = terceirovalor;
        }
        
        public int calcularSoma()
        {
            return (PrimeiroValor + SegundoValor + TerceiroValor);
        }

        
    }
}
