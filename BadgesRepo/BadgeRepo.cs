using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesRepo
{
    public class BadgeRepo
    {
        
        private List<Master> _masterlist = new List<Master>();

        //Create a dictionary of badges
        Dictionary<string, Badge> Badges = new Dictionary<string, Badge>
        {
            { "12345", 12345 },
            { "22345", 22345 },
            { "32345", 32345 },

        };
        public static Badge 
        //key for the dictionary will be the BadgeID
        //the valuefor the dictionary will be the badge

        //create a new badge public Badge(  int badgeID, string doorAccess, string developerTeamA, string master) 
        new public Badge()
        //update doors on existing badge
        //delete all doors from an existing badge
        //show a list with all badge numbers and door access
    }
}
//SeedContentList
//Add a badge
//What is the number on the badge: 12345

//List a door that it needs access to: A5

//Any other doors(y/n)? y

//List a door that it needs access to: A7

//Any other doors(y/n)? n

//(Return to main menu.)

//Update a badge
//What is the badge number to update? 12345

//12345 has access to doors A5 & A7.

//What would you like to do?

//Remove a door
//Add a door
//> 1

//Which door would you like to remove? A5

//Door removed.

//12345 has access to door A7.

//#3 List all badges view
//Badge #	Door Access
//12345   A7
//22345   A1, A4, B1, B2
//32345   A4, A5
