using RodoviariaOnline.Dominio.Entidades;

namespace RodoviariaOnline.Dominio.Servicos.Contratos
{
    public interface IVerificadorDeReserva
    {
        Reserva VerificarPorDocumentoOuPoltrona(string numeroDoDocumento, int numeroDaPoltrona);
    }
}