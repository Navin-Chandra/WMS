using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class CityRepository : ICityRepository
    {
        public List<CityModel> GetCityList()
        {
            List<CityModel> cityList = new List<CityModel>();

            cityList.Add(new CityModel(1, 1, "Achampet"));
            cityList.Add(new CityModel(1, 2, "Adilabad "));
            cityList.Add(new CityModel(1, 3, "Adoni "));
            cityList.Add(new CityModel(1, 4, "Alampur "));
            cityList.Add(new CityModel(1, 5, "Allagadda "));
            cityList.Add(new CityModel(1, 6, "Alur"));
            cityList.Add(new CityModel(2, 7, "Bordumsa"));
            cityList.Add(new CityModel(2, 8, "BordumsaBubang"));
            cityList.Add(new CityModel(2, 9, "BordumsaChanglang"));
            cityList.Add(new CityModel(2, 10, "BordumsaChopelling"));
            cityList.Add(new CityModel(2, 11, "BordumsaDeban"));
            cityList.Add(new CityModel(2, 12, "BordumsaDharampur"));
            cityList.Add(new CityModel(2, 13, "BordumsaGandhigram"));
            cityList.Add(new CityModel(2, 14, "BordumsaJairampur"));
            cityList.Add(new CityModel(2, 15, "BordumsaKharsang"));
            return cityList;

        }
    }
}