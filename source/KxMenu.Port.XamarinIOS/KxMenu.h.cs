using System;

namespace Default.Namespace
{
    public class KxMenuItem
    {
        public UIImage Image {get; set;}

        public string Title {get; set;}

        public object Target {get; set;}

        public SEL Action {get; set;}

        public UIColor ForeColor {get; set;}

        public NSTextAlignment Alignment {get; set;}

        static instancetype MenuItemImageTargetAction(string title, UIImage image, object target, SEL action);

    }
    public class KxMenu
    {
        static void ShowMenuInViewFromRectMenuItems(UIView view, CGRect rect, ArrayList menuItems);

        static void DismissMenu();

        static UIColor TintColor();

        static void SetTintColor(UIColor tintColor);

        static UIFont TitleFont();

        static void SetTitleFont(UIFont titleFont);

    }
}
