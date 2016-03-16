using System;
using System.Collections.Generic;

#if ! __CLASSIC__
using Foundation;
using UIKit;
using CoreGraphics;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

using CGRect=System.Drawing.RectangleF;
using nfloat=System.Single;
#endif

using KxMenu;

namespace Sample.KxMenu.Bindings
{
	public partial class ViewController : UIViewController
	{
		UIButton _btn1;
		UIButton _btn2;
		UIButton _btn3;
		UIButton _btn4;
		UIButton _btn5;
		UIButton _btn6;
		UIButton _btn7;

		public ViewController () : base ("ViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

		public override void LoadView ()
		{
			// CGRect frame = [[UIScreen mainScreen] applicationFrame];
    		CGRect frame = UIScreen.MainScreen.ApplicationFrame;

		    // self.view = [[UIView alloc] initWithFrame:frame];
			//self.view.backgroundColor = [UIColor whiteColor];
			// self.view.autoresizingMask = UIViewAutoresizingFlexibleHeight|UIViewAutoresizingFlexibleWidth;
		    this.View = new UIView(frame);
		    this.View.BackgroundColor = UIColor.White;
			this.View.AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;

		    //const CGFloat W = self.view.bounds.size.width;
		    //const CGFloat H = self.view.bounds.size.height;
			nfloat W = this.View.Bounds.Size.Width;
			nfloat H = this.View.Bounds.Size.Height;

		    //_btn1 = [UIButton buttonWithType:UIButtonTypeRoundedRect];
		    //_btn1.frame = CGRectMake(5, 5, 100, 50);
		    //[_btn1 setTitle:@"Click me" forState:UIControlStateNormal];
		    //[_btn1 addTarget:self action:@selector(showMenu:) forControlEvents:UIControlEventTouchUpInside];
		    //[self.view addSubview:_btn1];

		    _btn1 = new UIButton(UIButtonType.RoundedRect);
		    _btn1.Frame = new CGRect(5, 5, 100, 50);
		    _btn1.SetTitle("Click me", UIControlState.Normal);
		    _btn1.AddTarget(ShowMenu, UIControlEvent.TouchUpInside);
		    this.View.AddSubview(_btn1);

			_btn2 = new UIButton(UIButtonType.RoundedRect);
		    _btn2.Frame = new CGRect(5, H - 55, 100, 50);
		    _btn2.SetTitle("Click me", UIControlState.Normal);
		    _btn2.AddTarget(this.ShowMenu, UIControlEvent.TouchUpInside);
		    this.View.AddSubview(_btn2);

			_btn3 = new UIButton(UIButtonType.RoundedRect);
		    _btn3.Frame = new CGRect(W - 105, 5, 100, 50);
		    _btn3.SetTitle("Click me", UIControlState.Normal);
		    _btn3.AddTarget(this.ShowMenu, UIControlEvent.TouchUpInside);
		    this.View.AddSubview(_btn3);

			_btn4 = new UIButton(UIButtonType.RoundedRect);
		    _btn4.Frame = new CGRect(W - 105, H - 55, 100, 50);
		    _btn4.SetTitle("Click me", UIControlState.Normal);
		    _btn4.AddTarget(this.ShowMenu, UIControlEvent.TouchUpInside);
		    this.View.AddSubview(_btn4);

			_btn5 = new UIButton(UIButtonType.RoundedRect);
		    _btn5.Frame = new CGRect(5, (H - 50) * 0.5f, 100, 50);
		    _btn5.SetTitle("Click me", UIControlState.Normal);
		    _btn5.AddTarget(this.ShowMenu, UIControlEvent.TouchUpInside);
		    this.View.AddSubview(_btn5);

			_btn6 = new UIButton(UIButtonType.RoundedRect);
		    _btn6.Frame = new CGRect(W - 105, (H - 50) * 0.5f, 100, 50);
		    _btn6.SetTitle("Click me", UIControlState.Normal);
		    _btn6.AddTarget(this.ShowMenu, UIControlEvent.TouchUpInside);
		    this.View.AddSubview(_btn6);

			_btn7 = new UIButton(UIButtonType.RoundedRect);
		    _btn7.Frame = new CGRect((W - 100) * 0.5f, (H - 50) * 0.5f, 100, 50);
		    _btn7.SetTitle("Click me", UIControlState.Normal);
		    _btn7.AddTarget(this.ShowMenu, UIControlEvent.TouchUpInside);
		    this.View.AddSubview(_btn7);



			return;
		}

		public override void ViewDidLayoutSubviews()
		{
			// Perform any additional setup after loading the view, typically from a nib.

			_btn1 =  new UIButton();
			_btn2 =  new UIButton();
			_btn3 =  new UIButton();
			_btn4 =  new UIButton();
			_btn5 =  new UIButton();
			_btn6 =  new UIButton();
			_btn7 =  new UIButton();

			nfloat W = this.View.Bounds.Size.Width;
		    nfloat H = this.View.Bounds.Size.Height;

		    #if ! __CLASSIC__
		    _btn1.Frame = new CoreGraphics.CGRect(5, 5, 100, 50);
			_btn2.Frame = new CoreGraphics.CGRect(5, H - 55, 100, 50);
			_btn3.Frame = new CoreGraphics.CGRect(W - 105, 5, 100, 50);
			_btn4.Frame = new CoreGraphics.CGRect(W - 105, H - 55, 100, 50);
			_btn5.Frame = new CoreGraphics.CGRect(5, (H-50) * 0.5, 100, 50);
			_btn6.Frame = new CoreGraphics.CGRect(W - 105, (H-50) * 0.5, 100, 50);
			_btn7.Frame = new CoreGraphics.CGRect((W - 100)* 0.5, (H-50) * 0.5, 100, 50);
			#else
			_btn1.Frame = new System.Drawing.RectangleF(5, 5, 100, 50);
			_btn2.Frame = new System.Drawing.RectangleF(5, H - 55, 100, 50);
			_btn3.Frame = new System.Drawing.RectangleF(W - 105, 5, 100, 50);
			_btn4.Frame = new System.Drawing.RectangleF(W - 105, H - 55, 100, 50);
			_btn5.Frame = new System.Drawing.RectangleF(5, (H-50) * 0.5f, 100, 50);
			_btn6.Frame = new System.Drawing.RectangleF(W - 105, (H-50) * 0.5f, 100, 50);
			_btn7.Frame = new System.Drawing.RectangleF((W - 100)* 0.5f, (H-50) * 0.5f, 100, 50);
			#endif
		    return;
		}

		private void ShowMenu(object sender, EventArgs ea)
		{
			List<KxMenuItem> menuItems = new List<KxMenuItem>()
			{
				new KxMenuItem()
				{
					Title = "ACTION MENU 1234456",
					Image = new UIImage("action_icon"),
					Target = null,
//					Action = null,				  
				},
				new KxMenuItem()
				{
					Title = "Share this",
					Image = new UIImage("action_icon"),
					Target = this,
				},
				new KxMenuItem()
				{
					Title = "Check this menu",
					Image = new UIImage("action_icon"),
					Target = this,
				},
				new KxMenuItem()
				{
					Title = "Reload page",
					Image = new UIImage("reload"),
					Target = this,
				},
				new KxMenuItem()
				{
					Title = "Search",
					Image = new UIImage("search_icon"),
					Target = this,
					//Action = PushMenuItem,				  
				},
				new KxMenuItem()
				{
					Title = "Go Home",
					Image = new UIImage("home_icon"),
					Target = this,
					//Action = PushMenuItem,				  
				},
			};

			#if ! __CLASSIC__
			nfloat r = new nfloat(47/255.0);
			nfloat g = new nfloat(112/255.0);
			nfloat b = new nfloat(225/255.0);
            nfloat a = new nfloat(1.0);
			#else
			float r = (47/255.0f);
			float g = (112/255.0f);
			float b = (225/255.0f);
            float a = (1.0f);
			#endif

			KxMenuItem first = menuItems[0];
			first.ForeColor = new UIColor(r, g, b, a);
			first.Alignment	= UITextAlignment.Center;

			global::KxMenu.KxMenu.ShowMenuInView
						(
							this.View, 
							((UIButton) sender).Frame, 
							menuItems.ToArray()
						);
			//this.View.
    		//[KxMenu showMenuInView:self.view
            //      fromRect:sender.frame
            //     menuItems:menuItems];

			return;
		}


		/*
			forgotten lib.a 

			Could not create an native instance of the type 
				'KxMenu.KxMenuItem': 
			the native class hasn't been loaded.
			It is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.
		*/

		void pushMenuItem(object sender)
		{
		    //NSLog(@"%@", sender);
		    Console.WriteLine(sender.ToString());

		    return;
		}
	}
}

