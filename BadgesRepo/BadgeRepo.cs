using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesRepo
{
    public class BadgeRepo
    {
        //Create a dictionary of badges
        Dictionary<int, Badge> _Badges = new Dictionary<int, Badge>();

        //key for the dictionary will be the BadgeID
        //the valuefor the dictionary will be the badge

        //create a new badge public Badge(  int badgeID, string doorAccess, string developerTeamA, string master) 
        public void AddABadge(Badge badge)
        {
            int badgeKey = badge.BadgeID;
            _Badges.Add(badgeKey, badge);
        }
        public Dictionary<int, Badge> ListAllBadges()
        {
            return _Badges;
        }

        public Badge GetABadge(int badgeWeWant)
        {
            Badge badge = new Badge();
            if (_Badges.ContainsKey(badgeWeWant))
            {
                //Establishing that the Key Value Pair within _Badges that contains badgeWeWant is now equal to badge
                badge = _Badges[badgeWeWant];
            }

            return badge;
        }
        //update doors on existing badge
        public void EditABadge(Badge badge, List<string> newdooraccess)
        {
            
            badge.DoorAccess = newdooraccess;
        }

        //delete all doors from an existing badge

        public void RemoveADoor(Badge badge, string doorID)
        {

            List<string> dooraccess = badge.DoorAccess;
            if (dooraccess.Contains(doorID))
            {
                dooraccess.Remove(doorID);
            }
        }
        //show a list with all badge numbers and door access
    }
}
