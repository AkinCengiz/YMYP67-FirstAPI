using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using YMYP67_FirstAPI.Business.Abstract;
using YMYP67_FirstAPI.Entities.Concrete;
using YMYP67_FirstAPI.Entities.Dtos.Product;

namespace YMYP67_FirsAPI.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        _productService.Insert(product);
        var p = new
        {
            product.Id,
            product.Name,
            product.Description,
            product.Price,
            product.Stock,
            product.ImageUrl,
            product.CategoryID
        };
        return Ok(p);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        //var response = _productService.GetAllQueryable().Include(p => p.Category).ToList();

        var response = _productService.GetList();

        List<ProductResponseDto> dtos = response.Select(p => new ProductResponseDto(p.Id,p.Name,p.Description,p.Price,p.Stock,p.Category.Name)).ToList();
        return Ok(dtos);
    }
}
