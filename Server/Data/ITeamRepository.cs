using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data
{

    public interface ITeamRepository
    {

        List<Team> GetAllTeams();
        Team GetTeamByID(int ID);

    }

}
