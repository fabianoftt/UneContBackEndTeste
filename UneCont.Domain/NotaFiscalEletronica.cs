using System;
using System.Collections.Generic;
using System.Text;

namespace UneCont.Domain
{
    public sealed class NotaFiscalEletronica : NotaFiscalBase
    {
        public int NumeroProcessoEletronico { get; set; }

        internal NotaFiscalEletronica(long numero, string nomeCliente, decimal valorNotaFiscal, DateTime? dataEmissao, int numeroProcessoEletronico)
        {
            NumeroNotaFiscal = numero;
            NomeCliente = nomeCliente;
            ValorNotaFiscal = valorNotaFiscal;
            DataEmissao = dataEmissao;
            DataCadastroNotaFiscal = DateTime.Now;
            NumeroProcessoEletronico = numeroProcessoEletronico;
        }
    }
}
