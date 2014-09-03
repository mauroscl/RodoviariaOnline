using System.Collections.Generic;

namespace RodoviariaOnline.Dominio.Repositorios
{
    public interface IRepositorioBase<T>
    {
        void Adicionar(T entidade);

        int Count();

        T SingleOrDefault();

        IEnumerable<T> List();

    }
}