﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using BeatSaberMarkupLanguage.Attributes;
using JetBrains.Annotations;

namespace SongCore.UI
{
    internal class SCSettingsController : INotifyPropertyChanged
    {
        [UIValue("colors")]
        public bool Colors
        {
            get => Plugin.Configuration.CustomSongColors;
            set
            {
                Plugin.Configuration.CustomSongColors = value;
                OnPropertyChanged();
            }
        }

        [UIValue("platforms")]
        public bool Platforms
        {
            get => Plugin.Configuration.CustomSongPlatforms;
            set => Plugin.Configuration.CustomSongPlatforms = value;
        }

        [UIValue("diffLabels")]
        public bool DiffLabels
        {
            get => Plugin.Configuration.DisplayDiffLabels;
            set => Plugin.Configuration.DisplayDiffLabels = value;
        }

        [UIValue("longPreviews")]
        public bool LongPreviews
        {
            get => Plugin.Configuration.ForceLongPreviews;
            set => Plugin.Configuration.ForceLongPreviews = value;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}