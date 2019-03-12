﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Top25NBAPlayers.Services.ViewModels;

namespace Top25NBAPlayers.Services.Services
{
    public interface ITeamService
    {
        List<TeamItemViewModel> GetTeams();
        TeamViewModel GetTeam(Guid id);
        Task<string> CreateTeam(TeamViewModel newTeam);
        Task<string> UpdateTeam(Guid teamId, TeamViewModel updatedTeam);
        Task<string> DeleteTeam(Guid teamId);
    }
}
