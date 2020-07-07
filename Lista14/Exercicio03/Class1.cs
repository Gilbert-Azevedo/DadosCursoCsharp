using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Boleto
    {
        private string codBarras;
        private DateTime dateEmissao = new DateTime();
        private DateTime dateVencimento = new DateTime();
        private DateTime datePagto = new DateTime();
        private decimal valorBoleto, valorPago;
        private Pagamento situacaoPagamento;

        public Boleto(string cod, DateTime emissao, DateTime venc, decimal valor)
        {
            if (cod != null) codBarras = cod;
            dateEmissao = emissao;
            dateVencimento = venc;
            if (valor > 0) valorBoleto = valor;

        }

        public void Pagar(decimal valor)
        {
            datePagto = DateTime.Now;
            if (valor <= valorBoleto) valorPago = valor;
        }

          public Pagamento Situacao()
        {
            situacaoPagamento = Pagamento.EmAberto;

            if ((valorPago > 0) && (valorPago < valorBoleto))
            {
                situacaoPagamento = Pagamento.PagoParcial;
            }
            else
            {
                if (valorPago == valorBoleto) situacaoPagamento = Pagamento.Pago;
            }

            return situacaoPagamento;
        }
      


       public enum Pagamento {
            
            EmAberto, PagoParcial, Pago
        }

        public override string ToString()
        { 
          return $" Código de Barras :  {codBarras}  - Data de Emissão : {dateEmissao:dd/MM/yyyy} - Data de Vencimento : {dateVencimento:dd/MM/yyyy} \n" +
                $"- Data de Pagamento : {datePagto:MM / dd / yyyy}  - Valor do Boleto (R$) = {valorBoleto:0.00} - Valor Pago (R$) = {valorPago:0.00} \n" +
                $"- Situação: {Situacao()}";
        }


    }
}
