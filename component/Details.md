# Details

## KxMenu Usage

In ViewDidLayoutSubviews() create UIBUtton[s]:


		_btn1 =  new UIButton();
		_btn2 =  new UIButton();

		nfloat W = this.View.Bounds.Size.Width;
	    nfloat H = this.View.Bounds.Size.Height;

	    #if ! __CLASSIC__
	    _btn1.Frame = new CoreGraphics.CGRect(5, 5, 100, 50);
		_btn2.Frame = new CoreGraphics.CGRect(5, H - 55, 100, 50);
		#else
		_btn1.Frame = new System.Drawing.RectangleF(5, 5, 100, 50);
		_btn2.Frame = new System.Drawing.RectangleF(5, H - 55, 100, 50);
		#endif

In UIViewConotrller's LoadView() define UI details and set more properties to 
buttons[s]:

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

Now, define some menu items:

		List<KxMenuItem> menuItems = new List<KxMenuItem>()
		{
			new KxMenuItem()
			{
				Title = "ACTION MENU 1234456",
				Image = new UIImage("action_icon"),
				Target = null,
			},
			new KxMenuItem()
			{
				Title = "Share this",
				Image = new UIImage("action_icon"),
				Target = this,
			},
		};

Add menu items to KxMenu:

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



 
## References/Links

*	github repo		
	[https://github.com/kolyvan/kxmenu](https://github.com/kolyvan/kxmenu)
*	[]()		
	
*	[]()
*	[]()


*	[]()


