using Syncfusion.Maui.Themes;

namespace SyncfusionThemeSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ChangeSyncfusionControlsTheme(object sender, EventArgs e)
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
                        Application.Current.UserAppTheme = AppTheme.Light;
                    }
                    else
                    {
                        theme.VisualTheme = SfVisuals.MaterialDark;
                        Application.Current.UserAppTheme = AppTheme.Dark;
                    }
                }
            }
        }
    }

}
