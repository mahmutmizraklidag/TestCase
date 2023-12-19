using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Core.DTOs.Product;
using TestCase.Core.Entities;

namespace TestCase.Service.AutoMapper
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product,AddProductDTO>().ReverseMap();
            CreateMap<Product,GetProductDTO>().ReverseMap();
            CreateMap<Product,UpdateProductDTO>().ReverseMap();

        }
    }
}
