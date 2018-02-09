using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Server.Data
{

    public class TeamRepository : ITeamRepository
    {

        //--------------------------------------------------------------------------------------------------------------
        public List<Team> GetAllTeams()
        {

            using (TeamsContext context = new TeamsContext())
            {
                return context.Teams.Include(t => t.TeamType)
                                    .Include(t => t.Players)
                                    .AsNoTracking().ToList();
            }

        }

        //--------------------------------------------------------------------------------------------------------------
        public Team GetTeamByID(int ID)
        {

            using (TeamsContext context = new TeamsContext())
            {
                //context.Configuration.ProxyCreationEnabled = false;
                return context.Teams.Include(t => t.TeamType)
                                    .Include(t => t.Players)
                                    .AsNoTracking()
                                    .SingleOrDefault(t => t.ID == ID);
            }

        }

    }

}