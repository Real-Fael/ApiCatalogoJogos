using Microsoft.AspNetCore.Mvc;
using PrimeiroAppWebConsumindoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeiroAppWebConsumindoAPI.Service;

namespace PrimeiroAppWebConsumindoAPI.Controllers
{
    public class JogoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(Jogo jogo)
        {
            //** aqui deveria ser acionado pelo submit mas infelizmente ainda nao consegui fazer funcionar
            //** as requisições Update estao funcionando.
            DataService dataService = new DataService();

            
                dataService.UpdateJogoAsync(jogo);
           
          
           
            return RedirectToAction("Index");
        }

       
    }
}
