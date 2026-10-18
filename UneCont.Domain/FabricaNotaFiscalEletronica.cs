using System;
using System.Collections.Generic;
using System.Text;

namespace UneCont.Domain
{
    public class FabricaNotaFiscalEletronica : IFabricaNotaFiscalEletronica
    {
        public NotaFiscalEletronica CriarNotaFiscal(long numero, string? nomeCliente, decimal valorNotaFiscal, DateTime? dataEmissao, int numeroProcessoEletronico)
        {
            if (numero <= 0)
                throw new ArgumentException("O Número da nota fiscal deve ser maior que zero");

            if (string.IsNullOrWhiteSpace(nomeCliente))
                throw new ArgumentException("O Nome do cliente é obrigatório");

            if (valorNotaFiscal < 0)
                throw new ArgumentException("Valor da nota fiscal deve ser maior ou igual a zero");

            return new NotaFiscalEletronica(numero, nomeCliente, valorNotaFiscal, dataEmissao, numeroProcessoEletronico);
        }
    }
}
