using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]         
    //Attribute... -> Bir class ile ilgili bilgi verme, imzalama yöntemidir
    public class ProductsController : ControllerBase
    {
        //AddSingleton...
        //İçerisinde data içermeyen yapılar Singleton ile tutulabilir...
        //Eğer bir TService türünde bağımlılık görürsen, yanındaki sınıfı newler...
        //Loosely Coupled ---> Gevşek Bağlılık...
        //Manager Değişse bile bizi etkilemez...
        //IoC Container -- Inversion of Control...
        //Fieldlar genellikle "_" kullanılarak isimlendirilirler...
        //Autofac,Ninject,CastleWindsor,StructureMap,LightInject,DryInject --> .NET için IoC Cantainer...
        //AOP yapısı için gerekebilir...
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger...
            //Dependency Chain...
            
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbyid")]

        public IActionResult GetByID(int ID)
        {
            var result = _productService.GetByID(ID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
