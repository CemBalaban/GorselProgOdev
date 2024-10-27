using CommunityToolkit.Maui.Markup;

namespace GorselProgOdev;

public class App : Application
{
    public App(AppShell appShell)
    {
        Resources = new ResourceDictionary()
        {
            new Style<Shell>(
                (Shell.NavBarHasShadowProperty, true),
                (Shell.TitleColorProperty, Colors.White),
                (Shell.DisabledColorProperty, Colors.White),
                (Shell.UnselectedColorProperty, Colors.White),
                (Shell.ForegroundColorProperty, Colors.White),
                (Shell.BackgroundColorProperty, Colors.Purple)
                )
            .ApplyToDerivedTypes(true),

            new Style<NavigationPage>(
                (NavigationPage.BarTextColorProperty, Colors.White),
                (NavigationPage.BarBackgroundColorProperty, Colors.Purple))
            .ApplyToDerivedTypes (true)
        };

        MainPage = appShell;
    }
}

