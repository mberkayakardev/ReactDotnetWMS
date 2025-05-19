﻿using Core.Extentions.Concrete.Controller.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using Services.Abstract.AppService;

namespace WebApi.Controllers
{
    [ApiController]
    public class ProductsController : CostumeApiController
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }




        [HttpGet()]
        public async Task<IActionResult> GetAllProductForLanding()
        {
            return ActionResultInstance(await _productService.GetAllProductLandingPage());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByIdForlanding(int id)
        {
            return ActionResultInstance(await _productService.GetProductByIdForLanding(id));
        }


    }

}
