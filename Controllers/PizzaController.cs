﻿using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {

        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {

            List<Pizza> pizzasList = new List<Pizza>();
            
            Pizza Margherita = new Pizza("Margherita", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed", "pizza-margherita.jpg", "3,99");
            Pizza Marinara = new Pizza("Marinara", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed", "marinara.jpg", "3,00");
            Pizza Mortadella = new Pizza("Mortadella pistacchio e stracciatella", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed", "mortadella.jpg", "7,99");
            Pizza QuattroFormaggi = new Pizza("Quattro Formaggi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed", "formaggi.jpg", "5,99");
            Pizza Crudaiola = new Pizza("Crudaiola", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed", "crudaiola.jpg", "5,99");
            

            pizzasList.Add(Margherita);
            pizzasList.Add(Marinara);
            pizzasList.Add(Mortadella);
            pizzasList.Add(QuattroFormaggi);
            pizzasList.Add(Crudaiola);

            return View(pizzasList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}