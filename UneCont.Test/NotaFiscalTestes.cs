using UneCont.Domain;

namespace UneCont.Test
{
    public class NotaFiscalTestes
    {

        [Fact]
        public void CriarNotaFiscal_DeveLancarExcecao_QuandoNumeroMenorOuIgualZero()
        {
            var factory = new NotaFiscalFactory();

            var excecao = Assert.Throws<ArgumentException>(() =>
                factory.CriarNotaFiscal(0, "FABIANO", 100, DateTime.Now));

            Assert.Equal("O Número da nota fiscal deve ser maior que zero", excecao.Message);
        }

        [Fact]
        public void CriarNotaFiscal_DeveLancarExcecao_QuandoNomeClienteNaoEhInformado()
        {
            var factory = new NotaFiscalFactory();

            var excecao = Assert.Throws<ArgumentException>(() =>
                factory.CriarNotaFiscal(1, null, 100, DateTime.Now));

            Assert.Equal("O Nome do cliente é obrigatório", excecao.Message);
        }


        [Fact]
        public void CriarNotaFiscal_DeveLancarExcecao_QuandoNumeroMenorQueZero()
        {
            var factory = new NotaFiscalFactory();

            var excecao = Assert.Throws<ArgumentException>(() =>
                factory.CriarNotaFiscal(1, "FABIANO", -1, DateTime.Now));

            Assert.Equal("Valor da nota fiscal deve ser maior ou igual a zero", excecao.Message);
        }

        [Fact]
        public void CriarNotaFiscal_DeveRetornarNotaFiscal_QuandoParametrosValidos()
        {
            var factory = new NotaFiscalFactory();
            var dataEmissao = DateTime.Now;

            var nota = factory.CriarNotaFiscal(1, "FABIANO", 100, dataEmissao);

            Assert.NotNull(nota);
            Assert.Equal(1, nota.NumeroNotaFiscal);
            Assert.Equal("FABIANO", nota.NomeCliente);
            Assert.Equal(100, nota.ValorNotaFiscal);
            Assert.Equal(dataEmissao, nota.DataEmissao);
        }
    }
}
