using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class StationRepository : IStationRepository
    {
        public List<StationModel> GetStationList()
        {
            List<StationModel> stationList = new List<StationModel>();

            stationList.Add(new StationModel(1, 1, "AP-KO-01", 10));
            stationList.Add(new StationModel(1, 2, "AP-KO-02", 11));
            stationList.Add(new StationModel(1, 3, "AP-KO-03", 15));
            stationList.Add(new StationModel(1, 4, "AP-KO-04", 08));
            stationList.Add(new StationModel(1, 5, "AP-KO-05", 07));
            stationList.Add(new StationModel(1, 6, "AP-KO-06", 06));
            stationList.Add(new StationModel(2, 7, "AR-PR-07", 11));
            stationList.Add(new StationModel(2, 8, "AR-PR-08", 12));
            stationList.Add(new StationModel(2, 9, "AR-PR-09", 15));
            stationList.Add(new StationModel(2, 10, "AR-PR-10", 10));
            stationList.Add(new StationModel(2, 11, "AR-PR-11", 08));
            stationList.Add(new StationModel(2, 12, "AR-PR-17", 06));
            stationList.Add(new StationModel(2, 13, "AR-PR-13", 05));
            stationList.Add(new StationModel(2, 14, "AR-PR-14", 07));
            stationList.Add(new StationModel(2, 15, "AR-PR-15", 12));
            
            return stationList;

        }
    }
}