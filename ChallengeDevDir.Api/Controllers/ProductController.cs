using AutoMapper;
using ChallengeDevDir.Api.Responses;
using ChallengeDevDir.Core.DTOs;
using ChallengeDevDir.Core.Entities;
using ChallengeDevDir.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDevDir.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;
        public ProductController(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var products = await _repository.GetProducts();
                var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
                var response = new ApiResponse<IEnumerable<ProductDto>>(productsDto);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            try
            {
                var product = await _repository.GetProduct(id);
                var productDto = _mapper.Map<ProductDto>(product);
                var response = new ApiResponse<ProductDto>(productDto);
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> InsertProduct(ProductDto productDto)
        {
            try
            {
                var product = _mapper.Map<Producto>(productDto);
                await _repository.InsertProduct(product);
                productDto = _mapper.Map<ProductDto>(product);
                var response = new ApiResponse<ProductDto>(productDto);
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(int id, ProductDto productDto)
        {
            try
            {
                var product = _mapper.Map<Producto>(productDto);
                product.IdProducto = id;
                var result = await _repository.UpdateProduct(product);
                var response = new ApiResponse<bool>(result);
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                var result = await _repository.DeleteProduct(id);
                var response = new ApiResponse<bool>(result);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
