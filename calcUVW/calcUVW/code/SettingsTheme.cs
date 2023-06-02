using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using calcUVW.pages;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace calcUVW.code
{
    public class SettingsTheme
    {
        public IList<AppThemeViewModel> AppThemes { get; set; } = new List<AppThemeViewModel> {
        new AppThemeViewModel() { Key = (int)OSAppTheme.Unspecified },
        new AppThemeViewModel() { Key = (int)OSAppTheme.Light },
        new AppThemeViewModel() { Key = (int)OSAppTheme.Dark }
        };

        public ICommand SetAppThemeCommand { get; set; }

        public ThemePickerViewModel()
        {
            SetAppThemeCommand = new Command<AppThemeViewModel>((x) => SetAppTheme(x));
        }

        void SetAppTheme(AppThemeViewModel theme)
        {
            Application.Current.UserAppTheme = (OSAppTheme)theme.Key;
            Preferences.Set(Settings.AppTheme, theme.Key);
        }
    }
