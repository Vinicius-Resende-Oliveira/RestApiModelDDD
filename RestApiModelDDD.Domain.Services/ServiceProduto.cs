using RestApiModelDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using RestApiModelDDD.Domain.Entitys;

namespace RestApiModelDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, iServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            :base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}
