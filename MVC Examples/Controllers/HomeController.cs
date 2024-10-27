using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Xml.Linq;
using System;
using MVC_Examples.Models;

namespace MVC_Examples.Controllers
{
    public class HomeController : Controller
    {
        #region sample explanation
        //public IActionResult Index()
        //{
        //    return View();//send ViewResult object to client as response.
        //    // Expected Location is Views(Views folder)/Home(controllerName folder)/Index(nameOfAction).cshtml
        //    // If Index.cshtml is not presend in above loc, then it will also check in Views/Shared/Index.cshtml
        //    // even file not exists in shared then view index not found error.

        //    //The ViewResult contains information about which view to render.By default,
        //    //it looks for a view that matches the name of the action method.For example,
        //    //if your action is named Index, it will look for a view named Index.cshtml.

        //    //You can also pass a model to the view using return
        //    Person person =new Person(); // never do this coding just a sample.
        //    return View(person); //This will send person model object to Index.cshtml
        //    //This model can then be accessed within the view to populate the UI.

        //    return View("abc"); // this means send ViewResult object of view abc.cshtml.


        //}
        #endregion

        [Route("Home")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["heading msg"] = "Persons Details";
            ViewData["mycars"] = new List<string>() {
                "Toyota",
                "Ignis",
                "maruthi"
            };
            return View();
        }

        [Route("cars")]
        public IActionResult Car()
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){
                    id = 1,
                    name = "Audi",
                    number="123"
                },
                new Car(){
                    id = 2,
                    name = "Maruthiu",
                    number="rr4"
                },
                  new Car(){
                    id = 3,
                    name = "toyota",
                    number="rrgg4"
                }
            };
            return View(cars);
        }

        [Route("details/{name}")]
        public IActionResult Cardetails(string name)
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){
                    id = 1,
                    name = "Audi",
                    number="123"
                },
                new Car(){
                    id = 2,
                    name = "Maruthiu",
                    number="rr4"
                },
                  new Car(){
                    id = 3,
                    name = "toyota",
                    number="rrgg4"
                }
            };
            Car? car = cars.Where(c=>c.name==name).FirstOrDefault();
            return View(car);
        }
    }
}
