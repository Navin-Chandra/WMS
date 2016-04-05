using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult StateList()
        {
            StateRepository stateRepository = new StateRepository();
            return Json(stateRepository.GetStateList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult CityList(int id)
        {
            CityRepository cityRepository = new CityRepository();
            List<CityModel> cityList = new List<CityModel>();
            cityList = cityRepository.GetCityList();

            var filterData = cityList.FindAll(x => x.StateId == id);
            return Json(filterData, JsonRequestBehavior.AllowGet);
        }

        public JsonResult StationList(int id)
        {
            StationRepository stationRepository = new StationRepository();
            List<StationModel> cityList = new List<StationModel>();
            cityList = stationRepository.GetStationList();

            var filterData = cityList.Find(x => x.CityId == id);
            return Json(filterData, JsonRequestBehavior.AllowGet);
        }
            
    }
}