using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModelDDD.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
