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
            return ValidationProblem(ModelState);
        }
        // add the response headers so the view can be rendered as an svg
        Response.Headers.ContentType = "image/svg+xml";
        
        return View(model);

    }
    
}