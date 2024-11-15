using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

/*Course: 		Web Programming 3
* Assessment: 	Milestone 3
* Created by: 	Brayden Fournier - 6194481
* Date: 		15/11/2024
* Class Name: 	HomeController.cs
* Description: 	This controller holds all main logic for returning the main view aswell as an error view in the case of errors.
* Time Task B):	Ch 1 + 2: 1 Hour.
*/

namespace HPlusSport.Security.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
