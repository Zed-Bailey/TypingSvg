using Microsoft.AspNetCore.Mvc;
using TypingSvg.Models;

namespace TypingSvg.Controllers;

public class TypingController : Controller
{

    public TypingController()
    {
        
    }

    public IActionResult Index(TypingViewModel model)
    {
        model.Lines = Request.Query["lines"];
     
        if (!ModelState.IsValid)
        {
            Console.WriteLine("Invalid model state");
            return BadRequest("invalid model");
        }
        
        
        
        
        Response.Headers.ContentType = "image/svg+xml";
        return View(model);

    }
    
}