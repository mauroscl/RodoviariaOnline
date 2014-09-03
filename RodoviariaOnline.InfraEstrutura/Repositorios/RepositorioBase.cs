using System.Collections.Generic;
using RodoviariaOnline.Dominio.Repositorios;

namespace RodoviariaOnline.InfraEstrutura.Repositorios
{
    public class RepositorioBase<T>: IRepositorioBase<T>
    {
        public void Adicionar(T entidade)
        {
            throw new System.NotImplementedException();
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public T SingleOrDefault()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> List()
        {
            throw new System.NotImplementedException();
        }
    }
}
