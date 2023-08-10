using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectone
{
    public class Dictionary
    {
public void eplTeams()
        {
            Dictionary<string, string> teams = new Dictionary<string, string>();
            teams.Add("manchester", "manu,mancity");
            teams.Add("london", "chealsea,arsenal");
            foreach(string team in teams.Keys)
            {
                Console.WriteLine($"{team}:{teams[team]}");
            }
        }
    }
}
