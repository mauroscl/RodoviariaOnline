using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RodoviariaOnline.Dominio.Entidades;
using RodoviariaOnline.Dominio.Servicos.Contratos;

namespace RodoviariaOnline.Dominio.Servicos.Implementacoes
{
    public class ServicoDeReserva: IServicoDeReserva
    {
        private readonly IVerificadorDeReserva _verificadorDeReserva;

        public ServicoDeReserva(IVerificadorDeReserva verificadorDeReserva)
        {
            _verificadorDeReserva = verificadorDeReserva;
        }

        public Reserva Reservar(string tipoDoDocumento, string numeroDoDocumento, int numeroDaPoltrona)
        {
            Reserva reservaEncontrada = _verificadorDeReserva.VerificarPorDocumentoOuPoltrona(numeroDoDocumento, numeroDaPoltrona);

            if (reservaEncontrada != null)
            {
                if (reservaEncontrada.NumeroDoDocumento == numeroDoDocumento)
                {
                    throw new Exception("Já existe reserva para o documento");
                }

                if (reservaEncontrada.NumeroDaPoltrona == numeroDaPoltrona)
                {
                    throw new Exception("Assento ocupado");
                }
                
            }

            var novaReserva = new Reserva(tipoDoDocumento, numeroDoDocumento, numeroDaPoltrona);

            return novaReserva;
        }
    }
}
