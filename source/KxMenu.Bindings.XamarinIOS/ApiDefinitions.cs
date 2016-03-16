#if ! __CLASSIC__
using Foundation;
using ObjCRuntime;
using UIKit;
using CoreGraphics;
#else
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using System.Drawing;
#endif

namespace KxMenu
{
	// @interface KxMenuItem : NSObject
	[BaseType (typeof(NSObject))]
	interface KxMenuItem
	{
		// @property (readwrite, nonatomic, strong) UIImage * image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image
		{
			get;
			set;
		}

		// @property (readwrite, nonatomic, strong) NSString * title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title
		{
			get;
			set;
		}

		// @property (readwrite, nonatomic, weak) id _Nullable target;
		[NullAllowed, Export ("target", ArgumentSemantic.Weak)]
		NSObject Target
		{
			get;
			set;
		}

		// @property (readwrite, nonatomic) SEL action;
		[Export ("action", ArgumentSemantic.Assign)]
		Selector Action
		{
			get;
			set;
		}

		// @property (readwrite, nonatomic, strong) UIColor * foreColor;
		[Export ("foreColor", ArgumentSemantic.Strong)]
		UIColor ForeColor
		{
			get;
			set;
		}

		// @property (readwrite, nonatomic) NSTextAlignment alignment;
		[Export ("alignment", ArgumentSemantic.Assign)]
		UITextAlignment Alignment
		{
			get;
			set;
		}

		// +(instancetype)menuItem:(NSString *)title image:(UIImage *)image target:(id)target action:(SEL)action;
		[Static]
		[Export ("menuItem:image:target:action:")]
		KxMenuItem MenuItem (string title, UIImage image, NSObject target, Selector action);
	}

	// @interface KxMenu : NSObject
	[BaseType (typeof(NSObject))]
	interface KxMenu
	{
		// +(void)showMenuInView:(UIView *)view fromRect:(CGRect)rect menuItems:(NSArray *)menuItems;
		[Static]
		[Export ("showMenuInView:fromRect:menuItems:")]
		//[Verify (StronglyTypedNSArray)]
		#if ! __CLASSIC__
		void ShowMenuInView (UIView view, CGRect rect, NSObject[] menuItems);
		#else
		void ShowMenuInView (UIView view, RectangleF rect, NSObject[] menuItems);
		#endif
		// +(void)dismissMenu;
		[Static]
		[Export ("dismissMenu")]
		void DismissMenu ();

		// +(UIColor *)tintColor;
		// +(void)setTintColor:(UIColor *)tintColor;
		[Static]
		[Export ("tintColor")]
		//[Verify (MethodToProperty)]
		UIColor TintColor
		{
			get;
			set;
		}

		// +(UIFont *)titleFont;
		[Static]
		[Export ("titleFont")]
		UIFont TitleFont ();

		// +(void)setTitleFont:(UIFont *)titleFont;
		[Static]
		[Export ("setTitleFont:")]
		void SetTitleFont (UIFont titleFont);
	}
}