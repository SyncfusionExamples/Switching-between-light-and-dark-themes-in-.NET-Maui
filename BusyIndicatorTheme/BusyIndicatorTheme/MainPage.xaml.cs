﻿using Syncfusion.Maui.Themes;

namespace BusyIndicatorTheme
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                var theme = mergedDictionaries.OfType<SyncfusionThemeResourceDictionary>().FirstOrDefault();
                if (theme != null)
                {
                    if (theme.VisualTheme is SfVisuals.MaterialDark)
                    {
                        theme.VisualTheme = SfVisuals.MaterialLight;
                    }
                    else
                    {
                        theme.VisualTheme = SfVisuals.MaterialDark;
                    }
                }
            }
        }
    }

}
