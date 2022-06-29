﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepAPIDemo.Model;
using WepAPIDemo.Services;

namespace WepAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _prodservice;
        public ProductController(IProductServices prodservice)
        {
            _prodservice = prodservice;
        }
        [HttpGet]
       
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            return new ObjectResult(_prodservice.GetAllProducts());
            // test code
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product prod)
        {
            return new ObjectResult(_prodservice.AddProduct(prod));
        }

        [HttpPost]
        [Route("ModifyProduct")]
        public IActionResult ModifyProduct(Product prod)
        {
            return new ObjectResult(_prodservice.ModifyProduct(prod));
        }

        [HttpGet]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return new ObjectResult(_prodservice.DeleteProduct(id));
        }

    }
}
