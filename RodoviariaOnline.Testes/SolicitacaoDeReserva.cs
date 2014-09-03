using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RodoviariaOnline.Dominio.Entidades;
using RodoviariaOnline.Dominio.Repositorios;
using RodoviariaOnline.Dominio.Servicos.Contratos;
using RodoviariaOnline.Dominio.Servicos.Implementacoes;

namespace RodoviariaOnline.Testes
{
    [TestClass]
    public class SolicitacaoDeReserva
    {
        [TestMethod]
        public void Reserva_CpfInvalido_NaoPermitida()
        {

            Assert.Fail("não implementado");
        }


        [TestMethod]
        public void Reserva_RGInvalido_NaoPermitida()
        {
            //neste teste vamos mostar a idéia do principio Open Closed
            Assert.Fail("não implementado");
        }

        [TestMethod]
        public void Reserva_LugarOcupado_NaoPermitida()
        {
            //neste passo vamos incluir a dependência para o validador de reserva no serviço de reserva com um mock
            var verificadorDeReservaMock = new Mock<IVerificadorDeReserva>();
            const int numeroDaPoltrona = 30;
            verificadorDeReservaMock.Setup(x => x.VerificarPorDocumentoOuPoltrona(It.IsAny<string>(), numeroDaPoltrona))
                .Returns(new Reserva("CPF", "96894300097",numeroDaPoltrona));

            var servicoDeReserva = new  ServicoDeReserva(verificadorDeReservaMock.Object);

            servicoDeReserva.Reservar()
        }

        [TestMethod]
        public void Reserva_CpfValido_AssentoLivre_BemSucedida()
        {
            Assert.Fail("não implementado");
        }
    }
}
