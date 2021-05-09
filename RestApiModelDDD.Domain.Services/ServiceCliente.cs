using RestApiModelDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using RestApiModelDDD.Domain.Entitys;

namespace RestApiModelDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;
        public ServiceCliente(IRepositoryCliente repositoryCliente)
            :base (repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}
