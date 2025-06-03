using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YMYP67_FirstAPI.Business.Abstract;
using YMYP67_FirstAPI.Business.Concrete;
using YMYP67_FirstAPI.DataAccess.Concrete.EntityFramework;

namespace YMYP67_FirsAPI.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerManager;

    public CustomersController(ICustomerService customerManager)
    {
        _customerManager = customerManager;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Customer listesi");
    }
}
