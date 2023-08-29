using Microsoft.AspNetCore.Mvc;

namespace FanBarca.Controllers;

public class GuessThePlayerController : Controller
{
    public IActionResult GuessThePlayer()
    {
        return View();  
    }
}