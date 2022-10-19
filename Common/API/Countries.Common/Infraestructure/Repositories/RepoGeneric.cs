//using Common.Infraestructure.EF.Base;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Storage;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Common.Infraestructure.Repositories
//{
//    public abstract class RepoGeneric<T, K> : IRepoGeneric<T, K>, IRepoBase //where T : GenericEntity<K>, new()
//    {
//        /// <summary>
//        /// Objeto que representa el contexto de conexión a la base de datos
//        /// </summary>
//        protected BaseContext Db;
//        protected BaseContext ro_Db;
//        /// <summary>
//        /// Flag que indica, si la conexión a la base de datos se ha creado dentro de la clase o si se ha recibido por inyección
//        /// </summary>
//        protected bool _injectedContext = false;
//        /// <summary>
//        /// Variable que representa la tabla del modelo de negocio, que se recibe en la inicialización del objeto como T 
//        /// </summary>
//        protected DbSet<T> Table;
//        protected DbSet<T> ro_Table;
//        /// <summary>
//        /// Propiedad pública que proporciona acceso al contexto de la base de datos
//        /// </summary>
//        public BaseContext Context => Db;
//        /// <summary>
//        /// Por temas de auditoría, hay que insertar el Id de usuario en todos los registros de las tablas. 
//        /// Este Id, el ExceutionContext pasa al repositorio y el repositorio lo agrega al modelo que inserta o actualiza en la base de datos
//        /// </summary>
//        public int CurrentUserId { get; set; }

//        /// <summary>
//        /// Constructor por defecto
//        /// </summary>
//        /// 
//        protected RepoGeneric(RequestContext requestContext)
//        {
//            CurrentUserId = requestContext.UserId;
//        }

//        protected RepoGeneric(BaseContext context)
//        {
//            CurrentUserId = 0;
//            Db = context;
//            _injectedContext = true;
//            Table = Db.Set<T>();
//        }

//        /// <summary>
//        /// Constructor con parámetros
//        /// </summary>
//        /// <param name="context">Contexto de conexión a la base de datos</param>
//        public RepoGeneric(BaseContext context, BaseContext ro_context, RequestContext requestContext)
//        {
//            CurrentUserId = requestContext.UserId;
//            Db = context;
//            ro_Db = ro_context; // Todas por R+W  ro_Db = ro_context; // Separación  Read  / Write.
//            _injectedContext = true;
//            Table = Db.Set<T>();
//            ro_Table = ro_Db.Set<T>();
//        }


//        /// <summary>
//        /// Constructor con parámetros
//        /// </summary>
//        /// <param name="context">Contexto de conexión a la base de datos</param>
//        public RepoGeneric(BaseContext context, RequestContext requestContext)
//        {
//            CurrentUserId = requestContext.UserId;
//            Db = context;
//            _injectedContext = true;
//            Table = Db.Set<T>();
//        }

//        /// <summary>
//        /// Guarda las modificaciones acumuladas en el ChangeTracker
//        /// </summary>
//        /// <returns>0 en caso de error, un número entero positivo en caso de éxito</returns>
//        public virtual int SaveChanges()
//        {
//            try
//            {
//                //// Para la auditoría añadimos la información del usuario y de la fecha de creación/modificación del registro
//                //Db.ChangeTracker.Entries<BaseEntity>().Where(x => x.State == EntityState.Added).ToList().ForEach(x =>
//                //{
//                //    if (x.Properties.Any(p => p.Metadata.Name == "CreatedUserId")) x.Entity.CreatedUserId = CurrentUserId;
//                //    if (x.Properties.Any(p => p.Metadata.Name == "CreatedDate")) x.Entity.CreatedDate= DateTime.UtcNow;
//                //    if (x.Properties.Any(p => p.Metadata.Name == "ModifiedUserId")) x.Entity.ModifiedUserId = default;
//                //});
//                //Db.ChangeTracker.Entries<BaseEntity>().Where(x => x.State == EntityState.Modified).ToList().ForEach(x =>
//                //{
//                //    // El campo CreatedUserId está marcado como JsonIgnore, por tanto no viaja al FrontEnd ni viene de vuelta. 
//                //    // Dado que no queremos modificarlo con el valor por defecto, lo excluimos de ser actualizado
//                //    if (x.Properties.Any(p => p.Metadata.Name == "CreatedUserId")) x.Property(y => y.CreatedUserId).IsModified = false;
//                //    if (x.Properties.Any(p => p.Metadata.Name == "CreatedDate")) x.Property(y => y.CreatedDate).IsModified = false;
//                //    if (x.Properties.Any(p => p.Metadata.Name == "ModifiedUserId")) x.Entity.ModifiedUserId = CurrentUserId;
//                //    if (x.Properties.Any(p => p.Metadata.Name == "ModifiedDate")) x.Entity.ModifiedDate = DateTime.UtcNow;
//                //});

//                int result = Db.SaveChangesAsync().GetAwaiter().GetResult();                
//                return result;
//            }
//            catch (DbUpdateConcurrencyException ex)
//            {
//                throw ex;
//            }
//#pragma warning disable CS0168
//            catch (RetryLimitExceededException ex)
//            {
//                // TODO: AAC: Loguear el error de límite de reintendos agotado
//                // Una vez implementado el tratamiento de la excepción, borrar los #pragma warning disable/restore correspondientes
//                throw;
//            }
//#pragma warning restore CS0168
//#pragma warning disable CS0168
//            catch (Exception ex)
//            {
//                // TODO: AAC: Loguear errores genéricos
//                // Una vez implementado el tratamiento de la excepción, borrar los #pragma warning disable/restore correspondientes
//                throw;
//            }
//            finally
//            {
//                DetachAllEntities();
//            }
//#pragma warning restore CS0168
//        }
//        public virtual int Add(T entity, bool persist = true)
//        {
//            Table.Add(entity);
//            return persist ? SaveChanges() : 0;
//        }
//        public virtual int AddRange(IEnumerable<T> entities, bool persist = true)
//        {
//            Table.AddRange(entities);
//            return persist ? SaveChanges() : 0;
//        }
//        public virtual int Update(T entity, bool persist = true)
//        {
//            Table.Update(entity);
//            return persist ? SaveChanges() : 0;
//        }
//        public virtual int UpdateRange(IEnumerable<T> entities, bool persist = true)
//        {
//            Table.UpdateRange(entities);
//            return persist ? SaveChanges() : 0;
//        }
//        public virtual int Delete(T entity, bool persist = true)
//        {
//            Table.Remove(entity);
//            return persist ? SaveChanges() : 0;
//        }
//        public virtual int Delete(K id, byte[] timeStamp, bool persist = true)
//        {
//            T entry = GetEntryFromChangeTracker(id);
//            if(entry != null)
//            {
//                if(entry.ConcurrencyStamp == timeStamp)
//                {
//                    return Delete(entry, persist);
//                }
//                throw new Exception("Unable to delete record due to concurrency violation.");
//            }
//            Db.Entry(new T { Id = id, ConcurrencyStamp = timeStamp }).State = EntityState.Deleted;
//            return persist ? SaveChanges() : 0;
//        }
//        public virtual int DeleteRange(IEnumerable<T> entities, bool persist = true)
//        {
//            Table.RemoveRange(entities);
//            return persist ? SaveChanges() : 0;
//        }
//        internal T GetEntryFromChangeTracker(K id)
//        {
//            return Db.ChangeTracker.Entries<T>().Select(e => e.Entity).FirstOrDefault(e => e.Id.Equals(id));
//        }
//        public T Find(K id) => Table.Find(id);
//        public T GetFirst() => Table.FirstOrDefault();
//        public virtual IEnumerable<T> GetAll() => Table;
//        internal IEnumerable<T> GetRange(IQueryable<T> query, int skip, int take) => query.Skip(skip).Take(take);
//        public virtual IEnumerable<T> GetRange(int skip, int take) => GetRange(Table, skip, take);
//        public bool HasChanges => Db.ChangeTracker.HasChanges();
//        public int Count => Table.Count();


//        public Task<T> GetAsync(K id) => Table.FindAsync(id);


//        }

      
//        /// <summary>
//        /// Función para liberar las entradas que se crean en el change tracking.
//        /// Cuando en un contexto se van acumulando entradas el rendimiento se va degradando. En casos en los que
//        /// con una sola instancia del contexto se hacen muchas operaciones (ej. migraciones de datos, cargas desde fichero)
//        /// si es posible deberíamos ir detachando los datos que vamos tratando.
//        /// </summary>
//        public void DetachAllEntities()
//        {
//            List<Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry> changedEntriesCopy = Db.ChangeTracker.Entries()
//                //.Where(e => e.State == EntityState.Added ||
//                //            e.State == EntityState.Modified ||
//                //            e.State == EntityState.Deleted)
//                .ToList();

//            foreach (var entry in changedEntriesCopy)
//                entry.State = EntityState.Detached;
//        }


//        public IDbContextTransaction BeginTransaction()
//        {
//            return Db.Database.BeginTransaction();
//        }

//        public void UseTransaction(IDbContextTransaction transaction)
//        {
//            Db.Database.UseTransaction(transaction.GetDbTransaction());
//        }

//        public void CommitTransaction(IDbContextTransaction transaction)
//        {
//            transaction.Commit();
//        }

//        public void RollbackTransaction(IDbContextTransaction transaction)
//        {
//            transaction.Rollback();
//        }
//    }
//}
