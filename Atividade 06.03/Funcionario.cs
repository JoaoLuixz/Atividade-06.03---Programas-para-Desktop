using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_06._03
{
    public class Funcionario
    {
        public string Cpf { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public float ValorHora { get; set; }
        public float HorasTrabalhadas { get; set; }
        public float ValorSalario { get; private set; }
        public void CalcSalario()
        {
            ValorSalario = ValorHora * HorasTrabalhadas;
        }
    }
   
}
