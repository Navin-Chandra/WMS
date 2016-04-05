using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class StateModel
    {
        public int StateId { get; set; }
        public string StateName { get; set; }

        public StateModel(int stateId, string stateName)
        {
            this.StateId = stateId;
            this.StateName = stateName;
        }

    }

    

}