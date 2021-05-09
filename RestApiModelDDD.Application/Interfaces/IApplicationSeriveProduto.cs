using RestApiModelDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interfaces
{
    public interface IApplicationSeriveProduto
    {
        void Add(ProdutoDto produtoDto);
        void Upadte(ProdutoDto produtoDto);
        void Remove(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> GetAll();
        ProdutoDto GetById(int id);
    }
}
