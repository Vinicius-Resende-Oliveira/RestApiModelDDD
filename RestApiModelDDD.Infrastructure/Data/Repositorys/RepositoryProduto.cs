using RestApiModelDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModelDDD.Domain.Entitys;

namespace RestApiModelDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryProduto<TEntity> : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext)
            :base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
