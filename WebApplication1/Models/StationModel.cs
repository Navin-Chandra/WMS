
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class StationModel
    {
        public int CityId { get; set; }
        public int StationId { get; set; }
        public string StationCode { get; set; }
        public int PredictedSpeed { get; set; }

        public StationModel(int cityId, int stationId, string stationCode, int predictedSpeed)
        {
            this.CityId = cityId;
            this.StationId = stationId;
            this.StationCode = stationCode;
            this.PredictedSpeed = predictedSpeed;
        }
    }
}