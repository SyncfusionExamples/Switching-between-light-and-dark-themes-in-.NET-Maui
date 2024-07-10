# Applying Themes in Maui Controls

Syncfusion themes allow you to apply colors across all the Syncfusion controls with a uniform approach and provide a consistent look and feel to your applications. This section covers the following topics: 

* Applying light and dark themes
* Overriding the default theme
* Creating your own theme

## Applying light and dark themes

By default, Syncfusion offers support for both light and dark themes through the inclusion of a [SyncfusionThemeResourceDictionary](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Themes.SyncfusionThemeResourceDictionary.html).

To apply themes to your application, merge the [SyncfusionThemeResourceDictionary](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Themes.SyncfusionThemeResourceDictionary.html) item.

#### Theme resource dictionary

This resource dictionary includes keys and their corresponding color codes for all Syncfusion controls. Additionally, it contains the [VisualTheme](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Themes.SyncfusionThemeResourceDictionary.html#Syncfusion_Maui_Themes_SyncfusionThemeResourceDictionary_VisualTheme) property where we can declare the following two theme color values:

1. MaterialLight
2. MaterialDark

#### Automatic merging

When using more number of Syncfusion controls in an application, to make the process easier for merging the control style dictionaries of the controls, the [SyncfusionThemeResourceDictionary](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Themes.SyncfusionThemeResourceDictionary.html) class has been provided for automatic merging.

**XAML**
```
<Application xmlns:base="clr-namespace:SampleBrowser.Maui.Base;assembly=SampleBrowser.Maui.Base"
            xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
            x:Class="SampleBrowser.Maui.App"
            ...>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <!-- Theme resource dictionary -->
                <syncTheme:SyncfusionThemeResourceDictionary VisualTheme="MaterialDark"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>

    ....

</Application>
```

