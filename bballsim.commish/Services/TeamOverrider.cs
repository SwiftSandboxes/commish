using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using bballsim.commish.Models;

namespace bballsim.commish.Services
{
    public interface ITeamOverride
    {
        Team getById(int id);
        List<Team> getTeams();
    }

    public class TeamOverride : ITeamOverride
    {
        private Dictionary<int, Team> teamsCache = new Dictionary<int, Team>();

        public TeamOverride()
        {
            Team aTeam = new Team();
            aTeam.Id = 1;
            aTeam.TeamName = "ATeam";
            aTeam.OwnerId = "Hannibal";
            aTeam.LeagueId = "Eighties";
            teamsCache.TryAdd(aTeam.Id, aTeam);
        }

        public List<Team> getTeams()
        {
            return teamsCache.Values.ToList();
        }
        public Team getById(int id)
        {
            return teamsCache[id];
        }
    }
}