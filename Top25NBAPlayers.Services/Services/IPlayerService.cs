﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Top25NBAPlayers.Domain;
using Top25NBAPlayers.Services.ViewModels;

namespace Top25NBAPlayers.Services.Services
{
    public interface IPlayerService
    {
        List<PlayerItemViewModel> GetPlayers();
        List<PlayerItemViewModel> GetDeletedPlayers();
        PlayerViewModel GetPlayer(Guid id);
        Task<string> CreatePlayer(PlayerViewModel newPlayer);
        Task<string> UpdatePlayer(Guid playerId, PlayerViewModel updatedPlayer);
        Task<string> DeletePlayer(Guid playerId);
        Task<string> RestorePlayer(Guid playerId);
        Task<string> PermanentlyDeletePlayer(Guid playerId);
    }
}
