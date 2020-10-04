using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesRepo
{
    public class Badge
    {
        
        public int BadgeID { get; set; }
        public string DoorAccess { get; set; }
        public string DeveloperTeamA { get; set; }
        public string Master { get; set; }

        public Badge() { }
        public Badge(  int badgeID, string doorAccess, string developerTeamA, string master) 
        {
            BadgeID = badgeID;
            DoorAccess = doorAccess;
            DeveloperTeamA = developerTeamA;
            Master = master;

        }


        




    }
}