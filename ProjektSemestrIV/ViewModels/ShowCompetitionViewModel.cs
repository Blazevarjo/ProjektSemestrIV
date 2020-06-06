﻿using ProjektSemestrIV.Extensions;
using ProjektSemestrIV.Models;
using ProjektSemestrIV.Models.ShowModels;
using System.Collections.ObjectModel;

namespace ProjektSemestrIV.ViewModels
{
    class ShowCompetitionViewModel : BaseViewModel
    {
        private ShowCompetitionModel model;

        public string DurationDate { get; }
        public string Location { get; }
        public uint ShootersCount { get; }
        public string FastestShooter { get; }
        public string Podium { get; }
        public ObservableCollection<StageWithBestPlayerOverview> Stages { get; }
        public ObservableCollection<ShooterWithPointsOverview> Shooters { get; }

        public ShowCompetitionViewModel(uint id)
        {
            model = new ShowCompetitionModel(id);

            DurationDate = model.GetDurationDate();
            Location = model.GetLocation();
            ShootersCount = model.GetShootersCount();
            FastestShooter = model.GetFastestShooter();
            Podium = model.GetShootersOnPodium();

            Stages = model.GetStageWithBestShooters().Convert();
            Shooters = model.GetShootersFromCompetition().Convert();
        }
    }
}
