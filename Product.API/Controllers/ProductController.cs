﻿using Microsoft.AspNetCore.Mvc;
using Product.API.Dtos;
using Product.API.Service;

namespace Product.API.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody]CreateProductDto dto)
        {
            return Ok(_productService.Create(dto));
            return Ok("Created");
        }
        [HttpPut]
        public IActionResult Update([FromBody]UpdateProductDto dto)
        {
            return Ok(_productService.Update(dto));
            return Ok("Updated");
        }
        [HttpGet]
        public IActionResult Get(int Id)
        {
            return Ok(_productService.Get(Id));
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _productService.Delete(Id);
            return Ok("Deleted");
        }
    }
}
