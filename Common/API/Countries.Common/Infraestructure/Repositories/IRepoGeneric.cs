using System.Collections.Generic;
using Common.Infraestructure.EF.Base;
using Microsoft.EntityFrameworkCore.Storage;

namespace Common.Infraestructure.Repositories
{
    public interface IRepoGeneric<T, K> //where T : GenericEntity<K>
    {
        BaseContext Context { get; }
        int Count { get; }
        int CurrentUserId { get; set; }
        bool HasChanges { get; }

        int Add(T entity, bool persist = true);
        int AddRange(IEnumerable<T> entities, bool persist = true);
        //void ApplyAddsToContext<E, F>(IEnumerable<E> modified, IEnumerable<E> original) where E : GenericEntity<F>;
        //void ApplyAddsToContext<E>(IEnumerable<E> modified, IEnumerable<E> original) where E : GuidEntity;
        //void ApplyChangesToContext<E, F>(IEnumerable<E> modified, IEnumerable<E> original) where E : GenericEntity<F>;
        //void ApplyDeletesToContext<E, F>(IEnumerable<E> modified, IEnumerable<E> original) where E : GenericEntity<F>;
        //void ApplyDeletesToContext<E>(IEnumerable<E> modified, IEnumerable<E> original) where E : GuidEntity;
        int Delete(K id, byte[] timeStamp, bool persist = true);
        int Delete(T entity, bool persist = true);
        int DeleteRange(IEnumerable<T> entities, bool persist = true);
        T Find(K id);
        IEnumerable<T> GetAll();
        T GetFirst();
        IEnumerable<T> GetRange(int skip, int take);
        int SaveChanges();
        int Update(T entity, bool persist = true);
        int UpdateRange(IEnumerable<T> entities, bool persist = true);
        void DetachAllEntities();
        IDbContextTransaction BeginTransaction();
        void UseTransaction(IDbContextTransaction transaction);
        void CommitTransaction(IDbContextTransaction transaction);
        void RollbackTransaction(IDbContextTransaction transaction);
    }
}
