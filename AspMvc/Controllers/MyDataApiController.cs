using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AspMvc.Models;

[ApiController]
[Route("api/[controller]")]
public class MyDataApiController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var data = new List<MyDataModel>
        {
            new MyDataModel { Property1 = 1, Property2 = 100, Property3 = true },  // Change "Example 1" to an int
            new MyDataModel { Property1 = 2, Property2 = 200, Property3 = false }  // Change "Example 2" to an int
        };
        return Ok(data);
    }
}
