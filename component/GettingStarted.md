# Getting Started

## KxMenu

Xamarin.iOS bindings and component of KxMenu.

KxMenu is a vertical popup menu for using in Xamarin.iOS applications.


## Usage

1.	add component to the sample				
2.	initialize menu 			
```
		KxMenuItem first = menuItems[0];
		first.ForeColor = new UIColor(r, g, b, a);
		first.Alignment	= UITextAlignment.Center;

		global::KxMenu.KxMenu.ShowMenuInView
					(
						this.View, 
						((UIButton) sender).Frame, 
						menuItems.ToArray()
					);
```




## Requirements

at least iOS 5.0 

## Links/References


*	(https://github.com/kolyvan/kxmenu)[https://github.com/kolyvan/kxmenu]


Bindings and port:

*	(http://holisticware.net/holisticware)[http://holisticware.net/holisticware]





