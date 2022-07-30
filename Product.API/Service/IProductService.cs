using Product.API.Dtos;
using Product.API.Models;
using System.Collections.Generic;

namespace Product.API.Service
{
    public interface IProductService
    {
        void Delete(int Id);
        ProductEntity Get(int Id);
        List<ProductEntity> GetAll();
        int Create(CreateProductDto dto);
        int Update(UpdateProductDto dto);
    }
}