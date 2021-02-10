using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using catalog.api.DTOs;
using catalog.api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace catalog.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomBaseController
    {
        public ProductsController(ApplicationDbContext context,
                                  IMapper mapper)
                                  :base(context, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> Get()
        {
            return await Get<Product, ProductDTO>();
        }

        [HttpGet("{id:int}", Name = "getProduct")]
        public async Task<ActionResult<ProductDTO>> Get(int id)
        {
            return await Get<Product, ProductDTO>(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProductCreateDTO productCreateDTO)
        {
            return await Post<ProductCreateDTO, Product, ProductDTO>(productCreateDTO, "getProduct");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ProductCreateDTO productCreateDTO)
        {
            return await Put<ProductCreateDTO, Product>(id, productCreateDTO);
        }

        [HttpDelete("{id}")]        
        public async Task<ActionResult> Delete(int id)
        {
            return await Delete<Product>(id);
        }

    }
}
