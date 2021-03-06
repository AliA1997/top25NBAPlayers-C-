﻿using System;
using System.Collections.Generic;
using System.Text;
using Top25NBAPlayers.Domain;
using Top25NBAPlayers.Services.ViewModels;

namespace Top25NBAPlayers.Services.Factory
{
    public static class ModelFactory
    {
        public static PlayerItemViewModel CreateViewModel(Player playerToConvert, string team, DateTime? deleted_date)
        {

            if (deleted_date == null)
                return new PlayerItemViewModel()
                {
                    Id = playerToConvert.Id,
                    Name = playerToConvert.Name,
                    Avatar = playerToConvert.Avatar,
                    JerseyNumber = playerToConvert.JerseyNumber,
                    Team = team
                };
            else
                return new PlayerItemViewModel()
                {
                    Id = playerToConvert.Id,
                    Name = playerToConvert.Name,
                    Avatar = playerToConvert.Avatar,
                    JerseyNumber = playerToConvert.JerseyNumber,
                    Team = team,
                    Deleted_Date = DateTime.Parse($"{deleted_date}")
                };
        }
        public static PlayerViewModel CreateViewModel(Player playerToConvert)
        {
            return new PlayerViewModel()
            {
                Id = playerToConvert.Id,
                Name = playerToConvert.Name,
                Avatar = playerToConvert.Avatar,
                JerseyNumber = playerToConvert.JerseyNumber,
                AllStars = playerToConvert.AllStars,
                Mvps = playerToConvert.Mvps,
                Championships = playerToConvert.Championships,
                SeasonPoints = playerToConvert.SeasonPoints,
                SeasonAssists = playerToConvert.SeasonAssists,
                SeasonRebounds = playerToConvert.SeasonRebounds,
                SeasonFieldGoalPercentage = playerToConvert.SeasonFieldGoalPercentage
            };
        }

        public static TeamItemViewModel CreateViewModel(Guid teamId, string name, string logo, string greatestPlayer, DateTime? deleted_date)
        {
            if(deleted_date == null) 
                return new TeamItemViewModel()
                {
                    Id = teamId,
                    Name = name,
                    Logo = logo,
                    GreatestPlayer = greatestPlayer
                };
            else
                return new TeamItemViewModel()
                {
                    Id = teamId,
                    Name = name,
                    Logo = logo,
                    GreatestPlayer = greatestPlayer,
                    Deleted_Date = DateTime.Parse($"{deleted_date}")
                };
        }

        public static TeamViewModel CreateViewModel(Team teamToConvert)
        {
            return new TeamViewModel()
            {
                Id = teamToConvert.Id,
                Name = teamToConvert.Name,
                Logo = teamToConvert.Logo,
                GreatestPlayer = teamToConvert.GreatestPlayer,
                LastChampionship = teamToConvert.LastChampionship,
                Championships = teamToConvert.Championships
            };
        }

        public static UserViewModel CreateViewModel(AppUser userToConvert)
        {
            return new UserViewModel()
            {
                Id = userToConvert.Id, 
                DisplayName = userToConvert.DisplayName,
                Avatar = userToConvert.Avatar
            };
        }

        public static Player CreateDomainModel(PlayerViewModel playerToConvert, Guid teamId)
        {
            return new Player(
                        name: playerToConvert.Name,
                        avatar: playerToConvert.Avatar,
                        jerseyNumber: playerToConvert.JerseyNumber,
                        teamId: teamId,
                        mvps: playerToConvert.Mvps,
                        allstars: playerToConvert.AllStars,
                        championships: playerToConvert.Championships,
                        seasonPoints: playerToConvert.SeasonPoints,
                        seasonAssists: playerToConvert.SeasonAssists,
                        seasonRebounds: playerToConvert.SeasonRebounds,
                        seasonFieldGoalPercentage: playerToConvert.SeasonFieldGoalPercentage,
                        deletedInd: null
                    );
        }

        public static Team CreateDomainModel(TeamViewModel teamToConvert)
        {
            return new Team(
                        name: teamToConvert.Name,
                        logo: teamToConvert.Logo,
                        greatestPlayer: teamToConvert.GreatestPlayer,
                        lastChampionship: teamToConvert.LastChampionship,
                        championships: teamToConvert.Championships,
                        deletedInd: null
                    );
        }
    }
}
