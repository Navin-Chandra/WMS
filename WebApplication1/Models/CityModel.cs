using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace WebApplication1.Models
{
    public class CityModel
    {
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }

        public CityModel(int stateId, int cityId, string cityName)
        {
            this.StateId = stateId;
            this.CityId = cityId;
            this.CityName = cityName;
        }
    }
}