using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server.Controllers
{
    public class TeamsController : ApiController
    {

        private readonly ITeamRepository _TeamRepository;

        public TeamsController(ITeamRepository teamRepository)
        {
            _TeamRepository = teamRepository;
        }

        // GET: api/teams
        public IEnumerable<Team> Get()
        {
            List<Team> teams = _TeamRepository.GetAllTeams();
            return teams;
        }

        // GET: api/teams/5
        public Team Get(int id)
        {
            Team team = _TeamRepository.GetTeamByID(id);
            return team;
        }

        // POST: api/teams
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/teams/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/teams/5
        public void Delete(int id)
        {
        }
    }
}
