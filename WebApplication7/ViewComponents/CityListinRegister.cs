using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.ViewComponents.CityListinRegister
{
    public class CityListinRegister:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cityList = new List<CitiesModel>
            {
                new CitiesModel
                {
                    CityID=1,
                    CityName="Baku"
                },
                new CitiesModel
                {
                    CityID=2,
                    CityName="Anakar"
                },new CitiesModel
                {
                    CityID=3,
                    CityName="Anakara"
                }
            };
            return View(cityList);
        }
    }
}
