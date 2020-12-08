using AutoMapper;
using Loja.Dominio;
using Loja.Web.ViewModels.Product;
using Loja.Web.ViewModels.ProductProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Web.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ProductViewModel, Product>();
            Mapper.CreateMap<ProductProviderViewModel, ProductProvider>();
        }
    }
}