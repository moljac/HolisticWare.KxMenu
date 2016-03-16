using System;
#if ! __CLASSIC__
using Foundation;
#else
#endif

namespace KxMenu.Port.XamarinIOS
{
	/*
	@interface KxMenuItem : NSObject

	@property (readwrite, nonatomic, strong) UIImage *image;
	@property (readwrite, nonatomic, strong) NSString *title;
	@property (readwrite, nonatomic, weak) id target;
	@property (readwrite, nonatomic) SEL action;
	@property (readwrite, nonatomic, strong) UIColor *foreColor;
	@property (readwrite, nonatomic) NSTextAlignment alignment;

	+ (instancetype) menuItem:(NSString *) title
	                    image:(UIImage *) image
	                   target:(id)target
	                   action:(SEL) action;

	@end
	*/
	public partial class KxMenuItem : NSObject
	{
		public KxMenuItem ()
		{
		}
	}
}

