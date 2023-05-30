using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } // = new List<Person>(); (net 6)
        public string TeamName { get; set; }

        //for net 4
        public TeamModel()
        {
            TeamMembers = new List<PersonModel>();
        }
    }
}
