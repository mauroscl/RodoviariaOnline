using RodoviariaOnline.Dominio.Entidades;

namespace RodoviariaOnline.Dominio.Servicos.Contratos
{
    public interface IServicoDeReserva
    {
        Reserva Reservar(string tipoDoDocumento, string numeroDoDocumento, int numeroDaPoltrona);
    }
}