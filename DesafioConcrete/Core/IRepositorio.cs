using System;
using System.Collections.Generic;

namespace DesafioConcrete.Core
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(Guid id);
    }
}