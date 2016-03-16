using System;
using UIKit;
using CoreGraphics;

namespace KxMenu {
    
    
    internal class KxMenuView 
    { 
        
        #region Constructors
        public KxMenuView() {
            // {
            //     this = [super initWithFrame:CGRectZero];    
            //     if(this) {
            // 
            //         this.BackgroundColor = UIColor.Clear;
            //         this.opaque = true;
            //         this.alpha = 0;
            //         
            //         this.layer.shadowOpacity = 0.5;
            //         this.layer.shadowOffset = new CGSize(2, 2);
            //         this.layer.shadowRadius = 2;
            //     }
            //     
            //     return this;
            // }
        }
        #endregion
        
        #region Methods
        private void SetupFrameInView(UIView view) {
            // 
            //                  fromRect:(CGRect)fromRect
        }
        
        private void ShowMenuInView(UIView view) {
            // 
            //               fromRect:(CGRect)rect
        }
        
        private void DismissMenu(Boolean ) {
            // 
            // {
            //     if (this.superview) {
            //      
            //         if (animated) {
            //             
            //             _contentView.hidden = true;            
            //             const CGRect toFrame = (CGRect){this.arrowPoint, 1, 1};
            //             
            //             [UIView animateWithDuration:0.2
            //                              animations:^(void) {
            //                                  
            //                                  this.alpha = 0;
            //                                  this.Frame = toFrame;
            //                                  
            //                              } completion:^(bool finished) {
            //                                  
            //                                  if ([this.superview isKindOfClass:[KxMenuOverlay class]])
            //                                      [this.superview removeFromSuperview];
            //                                  [this removeFromSuperview];
            //                              }];
            //             
            //         } else {
            //             
            //             if ([this.superview isKindOfClass:[KxMenuOverlay class]])
            //                 [this.superview removeFromSuperview];
            //             [this removeFromSuperview];
            //         }
            //     }
            // }
        }
        
        private void PerformAction(Object sender) {
            // 
            // {
            //     [this dismissMenu:YES];
            //     
            //     UIButton button = (UIButton )sender;
            //     KxMenuItem menuItem = _menuItems[button.tag];
            //     [menuItem performAction];
            // }
        }
        
        private UIView MkContentView() {
            // 
            // {
            //     for (UIView v in this.subviews) {
            //         [v removeFromSuperview];
            //     }
            //     
            //     if (!_menuItems.count)
            //         return null;
            //  
            //     const CGFloat kMinMenuItemHeight = 32.f;
            //     const CGFloat kMinMenuItemWidth = 32.f;
            //     const CGFloat kMarginX = 10.f;
            //     const CGFloat kMarginY = 5.f;
            //     
            //     UIFont titleFont = [KxMenu titleFont];
            //     if (!titleFont) titleFont = [UIFont boldSystemFontOfSize:16];
            //     
            //     CGFloat maxImageWidth = 0;    
            //     CGFloat maxItemHeight = 0;
            //     CGFloat maxItemWidth = 0;
            //     
            //     for (KxMenuItem menuItem in _menuItems) {
            //         
            //         const CGSize imageSize = menuItem.image.Size;        
            //         if (imageSize.Width > maxImageWidth)
            //             maxImageWidth = imageSize.Width;        
            //     }
            //     
            //     if (maxImageWidth) {
            //         maxImageWidth += kMarginX;
            //     }
            //     
            //     for (KxMenuItem menuItem in _menuItems) {
            // 
            //         const CGSize titleSize = [menuItem.Title sizeWithFont:titleFont];
            //         const CGSize imageSize = menuItem.image.Size;
            // 
            //         const CGFloat itemHeight = MAX(titleSize.Height, imageSize.Height) + kMarginY  2;
            //         const CGFloat itemWidth = ((!menuItem.enabled && !menuItem.image) ? titleSize.Width : maxImageWidth + titleSize.Width) + kMarginX  4;
            //         
            //         if (itemHeight > maxItemHeight)
            //             maxItemHeight = itemHeight;
            //         
            //         if (itemWidth > maxItemWidth)
            //             maxItemWidth = itemWidth;
            //     }
            //        
            //     maxItemWidth  = MAX(maxItemWidth, kMinMenuItemWidth);
            //     maxItemHeight = MAX(maxItemHeight, kMinMenuItemHeight);
            // 
            //     const CGFloat titleX = kMarginX  2 + maxImageWidth;
            //     const CGFloat titleWidth = maxItemWidth - titleX - kMarginX  2;
            //     
            //     UIImage selectedImage = [KxMenuView selectedImage:(CGSize){maxItemWidth, maxItemHeight + 2}];
            //     UIImage gradientLine = [KxMenuView gradientLine: (CGSize){maxItemWidth - kMarginX  4, 1}];
            //     
            //     UIView contentView = new UIView(CGRectZero];
            //     contentView.AutoresizingMask = UIViewAutoresizingNone;
            //     contentView.BackgroundColor = UIColor.Clear;
            //     contentView.opaque = false;
            //     
            //     CGFloat itemY = kMarginY  2;
            //     NSUInteger itemNum = 0;
            //         
            //     for (KxMenuItem menuItem in _menuItems) {
            //                 
            //         const CGRect itemFrame = (CGRect){0, itemY, maxItemWidth, maxItemHeight};
            //         
            //         UIView itemView = new UIView(itemFrame];
            //         itemView.AutoresizingMask = UIViewAutoresizingNone;
            //         itemView.BackgroundColor = UIColor.Clear;        
            //         itemView.opaque = false;
            //                 
            //         [contentView addSubview:itemView];
            //         
            //         if (menuItem.enabled) {
            //         
            //             UIButton button = [UIButton buttonWithType:UIButtonTypeCustom];
            //             button.tag = itemNum;
            //             button.Frame = itemView.Bounds;
            //             button.enabled = menuItem.enabled;
            //             button.BackgroundColor = UIColor.Clear;
            //             button.opaque = false;
            //             button.AutoresizingMask = UIViewAutoresizingNone;
            //             
            //             [button addTarget:this
            //                        action:@selector(performAction:)
            //              forControlEvents:UIControlEventTouchUpInside];
            //             
            //             [button setBackgroundImage:selectedImage forState:UIControlStateHighlighted];
            //             
            //             [itemView addSubview:button];
            //         }
            //         
            //         if (menuItem.Title.length) {
            //             
            //             CGRect titleFrame;
            //             
            //             if (!menuItem.enabled && !menuItem.image) {
            //                 
            //                 titleFrame = (CGRect){
            //                     kMarginX  2,
            //                     kMarginY,
            //                     maxItemWidth - kMarginX  4,
            //                     maxItemHeight - kMarginY  2
            //                 };
            //                 
            //             } else {
            //                 
            //                 titleFrame = (CGRect){
            //                     titleX,
            //                     kMarginY,
            //                     titleWidth,
            //                     maxItemHeight - kMarginY  2
            //                 };
            //             }
            //             
            //             UILabel titleLabel = new UILabel(titleFrame];
            //             titleLabel.Text = menuItem.Title;
            //             titleLabel.Font = titleFont;
            //             titleLabel.TextAlignment = menuItem.alignment;
            //             titleLabel.TextColor = menuItem.foreColor ? menuItem.foreColor : [UIColor whiteColor];
            //             titleLabel.BackgroundColor = UIColor.Clear;
            //             titleLabel.AutoresizingMask = UIViewAutoresizingNone;
            //             //titleLabel.BackgroundColor = [UIColor greenColor];
            //             [itemView addSubview:titleLabel];            
            //         }
            //         
            //         if (menuItem.image) {
            //             
            //             const CGRect imageFrame = {kMarginX  2, kMarginY, maxImageWidth, maxItemHeight - kMarginY  2};
            //             UIImageView imageView = new UIImageView(imageFrame];
            //             imageView.image = menuItem.image;
            //             imageView.clipsToBounds = true;
            //             imageView.contentMode = UIViewContentModeCenter;
            //             imageView.AutoresizingMask = UIViewAutoresizingNone;
            //             [itemView addSubview:imageView];
            //         }
            //         
            //         if (itemNum < _menuItems.count - 1) {
            //             
            //             UIImageView gradientView = [[UIImageView alloc] initWithImage:gradientLine];
            //             gradientView.Frame = (CGRect){kMarginX  2, maxItemHeight + 1, gradientLine.Size};
            //             gradientView.contentMode = UIViewContentModeLeft;
            //             [itemView addSubview:gradientView];
            //             
            //             itemY += 2;
            //         }
            //         
            //         itemY += maxItemHeight;
            //         ++itemNum;
            //     }    
            //     
            //     contentView.Frame = (CGRect){0, 0, maxItemWidth, itemY + kMarginY  2};
            //     
            //     return contentView;
            // }
            throw new System.NotImplementedException();
        }
        
        private CGPoint ArrowPoint() {
            // 
            // {
            //     CGPoint point;
            //     
            //     if (_arrowDirection == KxMenuViewArrowDirectionUp) {
            //         
            //         point = (CGPoint){ CGRectGetMinX(this.Frame) + _arrowPosition, CGRectGetMinY(this.Frame) };
            //         
            //     } else if (_arrowDirection == KxMenuViewArrowDirectionDown) {
            //         
            //         point = (CGPoint){ CGRectGetMinX(this.Frame) + _arrowPosition, CGRectGetMaxY(this.Frame) };
            //         
            //     } else if (_arrowDirection == KxMenuViewArrowDirectionLeft) {
            //         
            //         point = (CGPoint){ CGRectGetMinX(this.Frame), CGRectGetMinY(this.Frame) + _arrowPosition  };
            //         
            //     } else if (_arrowDirection == KxMenuViewArrowDirectionRight) {
            //         
            //         point = (CGPoint){ CGRectGetMaxX(this.Frame), CGRectGetMinY(this.Frame) + _arrowPosition  };
            //         
            //     } else {
            //         
            //         point = this.center;
            //     }
            //     
            //     return point;
            // }
            throw new System.NotImplementedException();
        }
        
        private void DrawRect(CGRect rect) {
            // 
            // {
            //     [this drawBackground:this.Bounds
            //                inContext:UIGraphics.GetCurrentContext()];
            // }
        }
        
        private void DrawBackground(CGRect frame) {
            // 
            //              inContext:(CGContextRef) context
        }
        #endregion
        
        #region Static Methods
        public static UIImage SelectedImage(CGSize size) {
            // 
            // {
            //     const CGFloat locations[] = {0,1};
            //     const CGFloat components[] = {
            //         0.216, 0.471, 0.871, 1,
            //         0.059, 0.353, 0.839, 1,
            //     };
            //     
            //     return [this gradientImageWithSize:size locations:locations components:components count:2];
            // }
        }
        
        public static UIImage GradientLine(CGSize size) {
            // 
            // {
            //     const CGFloat locations[5] = {0,0.2,0.5,0.8,1};
            //     
            //     const CGFloat R = 0.44f, G = 0.44f, B = 0.44f;
            //         
            //     const CGFloat components[20] = {
            //         R,G,B,0.1,
            //         R,G,B,0.4,
            //         R,G,B,0.7,
            //         R,G,B,0.4,
            //         R,G,B,0.1
            //     };
            //     
            //     return [this gradientImageWithSize:size locations:locations components:components count:5];
            // }
        }
        
        public static UIImage GradientImageWithSize(CGSize ) {
            // 
            //                           locations:(const CGFloat []) locations
        }
        #endregion
    }
}
