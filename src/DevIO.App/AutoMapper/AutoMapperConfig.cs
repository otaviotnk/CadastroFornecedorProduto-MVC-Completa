using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Business.Models;

//MAPEAMENTO VIA AUTOMAPPER ENTRE AS ENTIDADES E AS VIEW MODELS

namespace DevIO.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}