using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YMYP67_FirstAPI.Business.Abstract;
using YMYP67_FirstAPI.Business.Concrete;
using YMYP67_FirstAPI.DataAccess.Concrete.EntityFramework;
using YMYP67_FirstAPI.Entities.Concrete;

namespace YMYP67_FirsAPI.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryManager;

    public CategoriesController(ICategoryService categoryManager)
    {
        _categoryManager = categoryManager;
    }


    [HttpGet]
    public IActionResult GetAll()
    {
        var response = _categoryManager.GetList();
        return Ok(response);
    }

    [HttpPost]
    public IActionResult Create(Category category)
    {
        _categoryManager.Insert(category);
        return Ok(category);
    }

    [HttpGet("{id}")]
    public IActionResult CategoryGetById(int id)
    {
        Category category = _categoryManager.GetById(id);
        if (category == null)
        {
            return NotFound($"Category with ID {id} not found.");
        }
        return Ok(category);
    }

    [HttpPut]
    public IActionResult Update(Category category)
    {
        _categoryManager.Modify(category);
        return Ok(category);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateById(int id,Category category)
    {
        Category response = _categoryManager.GetById(id);
        if (response == null)
        {
            return NotFound($"Category with ID {id} not found.");
        }
        response.Name = category.Name;
        response.Description = category.Description;
        response.IsActive = category.IsActive;
        _categoryManager.Modify(response);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        Category category = _categoryManager.GetById(id);
        if (category == null)
        {
            return NotFound($"Category with ID {id} not found.");
        }
        _categoryManager.Remove(category);
        return Ok($"Category with ID {id} has been deleted.");

    }

}
