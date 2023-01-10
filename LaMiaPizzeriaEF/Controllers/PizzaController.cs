using LaMiaPizzeriaEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeriaEF.Controllers {
    public class PizzaController : Controller {
        [Route("/pizze")]
        public IActionResult Index() {
            using var db = new PizzasDbContext();
            List<Pizza> pizzas = db.Pizzas.ToList();
            return View(pizzas);
        }

        [Route("pizze/{id}")]
        public IActionResult Pizza(int id) {
            using var db = new PizzasDbContext();
            Pizza? pizza = db.Pizzas.Find(id);
            return View(pizza);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(Pizza pizza) {
            if (!ModelState.IsValid) {
                return View("New", pizza);
            }

            using (var db = new PizzasDbContext()) {
                int modifications = db.AddPizza(pizza);
                Console.WriteLine(modifications);
            }

            return RedirectToAction("Index");
        }
    }
}
