using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DB;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {

        private Class shopContext;
        public SampleDataController(Class sc)
        {
            shopContext = sc;
        }
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //[HttpGet("[action]")]
        //public IEnumerable<WeatherForecast> WeatherForecasts()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    });
        //}

        [Route("prueba")]
        [HttpGet]
        public IList<Usuarios> Prueba()
        {
            Usuarios usuarios = shopContext.Usuarios.FirstOrDefault();
            IList<Usuarios> usuariosList = new List<Usuarios> { };
            usuariosList.Add(usuarios);
            return usuariosList;
        }

        [Route("agregarcarro")]
        [HttpPost]
        public BooleanTO AgregarCarro([FromBody] CarroTO carroTO)
        {
            try
            {
                Carro carro = new Carro { Color = carroTO.Color, Marca = carroTO.Marca, Placa = carroTO.Placa, Todoterreno = carroTO.TodoTerreno};
                shopContext.Carro.Add(carro);
                shopContext.SaveChanges();
                BooleanTO booleanTO = new BooleanTO
                {
                    Bool = true
                };
                return booleanTO;
            }
            catch (Exception ex)
            {
                BooleanTO booleanTO = new BooleanTO { Bool = false };
                return booleanTO;
            }
        }
    }
}
