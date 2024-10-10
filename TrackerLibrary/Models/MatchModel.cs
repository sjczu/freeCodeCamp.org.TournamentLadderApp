using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchModel
    {
        public List<MatchEntryModel> Entries { get; set; } = new List<MatchEntryModel>();
        public TeamModel WinnerTeam { get; set; }
        public ContestantModel WinnerName { get; set; }
        public ContestantModel WinnderId { get; set; }
        public int Round { get; set; }
    }
}
