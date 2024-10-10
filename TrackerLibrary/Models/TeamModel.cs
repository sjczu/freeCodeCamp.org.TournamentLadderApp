﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public List<ContestantModel> TeamMembers { get; set; } = new List<ContestantModel>();
    }
}
