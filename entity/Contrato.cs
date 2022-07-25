using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEnum.entity
{
    internal class Contrato
    {
        public int Numero { get; set; }
        public double Valor { get; set; }
        public DateTime DataContrato { get; set; }
        public int QtdParcelas { get; set; }

        public Contrato(int numero, double valor, int qtdParcelas, DateTime dataContrato)
        {
            Numero = numero;
            Valor = valor;
            QtdParcelas = qtdParcelas;
            DataContrato = dataContrato;
        }
    }
}
