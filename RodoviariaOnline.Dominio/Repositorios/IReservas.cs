using RodoviariaOnline.Dominio.Entidades;

namespace RodoviariaOnline.Dominio.Repositorios
{
    public interface IReservas: IRepositorioBase<Reserva>
    {
        IReservas PertencentesAPessoa(string numeroDoDocumentoDaPessoa);
        IReservas ParaOAssento(int numeroDoAssento);
    }
}