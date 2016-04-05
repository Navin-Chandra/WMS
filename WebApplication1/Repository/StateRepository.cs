using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class StateRepository : IStateRepository
    {
        public List<StateModel> GetStateList()
        {
            List<StateModel> stateList = new List<StateModel>();

            stateList.Add(new StateModel(1, "Andhra pradesh"));
            stateList.Add(new StateModel(2, "Arunachal Pradesh"));
            stateList.Add(new StateModel(3, "Assam"));
            stateList.Add(new StateModel(4, "Bihar"));
            stateList.Add(new StateModel(5, "Chhattisgarh"));
            stateList.Add(new StateModel(6, "Goa"));
            stateList.Add(new StateModel(7, "Gujarat"));
            stateList.Add(new StateModel(8, "Haryana"));
            stateList.Add(new StateModel(9, "Himachal pradesh"));
            stateList.Add(new StateModel(10, "Jammu & Kashmir"));
            stateList.Add(new StateModel(11, "Jharkhand"));
            stateList.Add(new StateModel(12, "Karnataka"));
            stateList.Add(new StateModel(13, "Kerala"));
            stateList.Add(new StateModel(14, "Madhya Pradesh"));
            stateList.Add(new StateModel(15, "Maharashtra"));
            stateList.Add(new StateModel(16, "Manipur"));
            stateList.Add(new StateModel(17, "Gujarat"));
            stateList.Add(new StateModel(18, "Meghalaya"));
            stateList.Add(new StateModel(19, "Mizoram"));
            stateList.Add(new StateModel(20, "Nagaland"));
            stateList.Add(new StateModel(21, "Orissa"));
            stateList.Add(new StateModel(22, "Punjab"));
            stateList.Add(new StateModel(23, "Rajasthan"));
            stateList.Add(new StateModel(24, "Sikkim"));
            stateList.Add(new StateModel(25, "Tamil Nadu"));
            stateList.Add(new StateModel(26, "Telangana"));
            stateList.Add(new StateModel(27, "Tripura"));
            stateList.Add(new StateModel(28, "Uttar Pradesh"));
            stateList.Add(new StateModel(29, "Uttarakhand"));
            stateList.Add(new StateModel(30, "West Bengal"));

            return stateList;

        }
    }
}