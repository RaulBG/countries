
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Storage;

//namespace namespace Common.Infraestructure.Repositories
//{
//    public abstract class RepoBase<T> : RepoGeneric<T, int> where T : BaseEntity, new()
//    {
//        /// <summary>
//        /// Constructor por defecto
//        /// </summary>
//        /// 
//        protected RepoBase(RequestContext requestContext)
//            : base(requestContext)
//        { }

//        /// <summary>
//        /// Constructor con parámetros
//        /// </summary>
//        /// <param name="context">Contexto de conexión a la base de datos</param>
//        protected RepoBase(BaseContext context, RequestContext requestContext)
//            : base(context, requestContext)
//        { }


//        protected RepoBase(BaseContext context)
//            : base(context)
//        { }

//        protected RepoBase(BaseContext context, BaseContext ro_context, RequestContext requestContext)
//            : base(context, ro_context, requestContext)
//        { }


//    }
//}
