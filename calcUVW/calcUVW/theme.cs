using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace calcUVW
{
    public static class theme
    {
        const int theme = 0;
        public static int theme
        {
            get => Preferences.Get(nameof(theme), theme);
            set => Preferences.Set(nameof(theme), value);
        }
    }
}
