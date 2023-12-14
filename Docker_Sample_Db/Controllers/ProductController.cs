using Docker_Sample_Db.Entities;
using Docker_Sample_Db.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Docker_Sample_Db.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAllProduct")]
        public async Task<IActionResult> GetAllProduct()
        {
            try
            {
                var products = await _productService.GetAllAsync();
                return Ok(products);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("GetAllProduct2")]
        public async Task<IActionResult> GetAllProduct2()
        {
            try
            {
                var products = await _productService.GetAllAsync2();
                return Ok(products);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("GetProductById/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            try
            {
                var product = await _productService.GetByIdAsync(id);
                return product == null ? NotFound() : Ok(product);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct(Product model)
        {
            try
            {
                var product = await _productService.CreateAsync(model);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] Product model)
        {
            try
            {
                var updateProduct = await _productService.UpdateAsync(model);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                await _productService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
