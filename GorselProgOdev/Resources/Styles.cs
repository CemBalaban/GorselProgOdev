using CommunityToolkit.Maui.Markup;

namespace GorselProgOdev.Resources;

public class Styles
{
    public static Style<Label> ResultLabelStyle = new Style<Label>(
        (Label.TextColorProperty, Colors.White),
        (Label.FontSizeProperty, 25),
        (Label.FontFamilyProperty, "OpenSansRegular"));

    public static Style<Label> FormulaLabelStyle = new Style<Label>(
        (Label.TextColorProperty, Colors.Black),
        (Label.FontSizeProperty, 25),
        (Label.FontFamilyProperty, "OpenSansRegular"));

    public static Style<Frame> ResultFrameStyle = new Style<Frame>(
        (Frame.BackgroundColorProperty, Colors.DarkOrange),
        (Frame.BorderColorProperty, Colors.DarkOrange),
        (Frame.HasShadowProperty, true),
        (Frame.ShadowProperty, Shadow.RadiusProperty),
        (Frame.CornerRadiusProperty, 20));

    public static Style<Frame> FormulaFrameStyle = new Style<Frame>(
        (Frame.BackgroundColorProperty, Colors.OrangeRed),
        (Frame.BorderColorProperty, Colors.OrangeRed),
        (Frame.HasShadowProperty, true),
        (Frame.ShadowProperty, Shadow.RadiusProperty),
        (Frame.CornerRadiusProperty, 20));

    public static Style<Button> NormalButtonStyle = new Style<Button>((Button.TextColorProperty, Colors.White), (Button.FontAttributesProperty, FontAttributes.Bold),
                                                            (Button.FontSizeProperty, 23),
                                                            (Button.FontFamilyProperty, "OpenSansRegular"));

    public static Style<Button> YellowButtonStyle = new Style<Button>((Button.TextColorProperty, Colors.Yellow), (Button.FontAttributesProperty, FontAttributes.Bold),
                                                            (Button.FontSizeProperty, 25),
                                                            (Button.FontFamilyProperty, "OpenSansRegular"));

    public static Style<Button> RedButtonStyle = new Style<Button>((Button.TextColorProperty, Colors.Red),
                                                            (Button.FontAttributesProperty, FontAttributes.Bold),
                                                            (Button.FontSizeProperty, 25),
                                                            (Button.FontFamilyProperty, "OpenSansRegular"));

    public static Style<BoxView> BoxViewStyle = new Style<BoxView>(
        (BoxView.ColorProperty, Colors.DarkOrange),
        (BoxView.CornerRadiusProperty, new CornerRadius(30, 30, 0, 0)));
}
