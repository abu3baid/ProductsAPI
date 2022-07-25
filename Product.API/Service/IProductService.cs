using Product.API.Models;
using System.Collections.Generic;

namespace Product.API.Service
{
    public interface IProductService
    {
        List<ProductEntity> GetAll();
    }
}