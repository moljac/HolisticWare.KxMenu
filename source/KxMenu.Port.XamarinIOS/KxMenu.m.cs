#import <QuartzCore/QuartzCore.h>

namespace Default.Namespace
{
    public class KxMenuOverlay : UIView
    {
        const CGFloat kArrowSize = 12.f;
        public enum KxMenuViewArrowDirection {
            None,
            Up,
            Down,
            Left,
            Right
        }
        static KxMenu gMenu;
        static UIColor gTintColor;
        static UIFont gTitleFont;

        KxMenu(CGRect frame)
            : base (frame)
        {
            this.BackgroundColor = UIColor.ClearColor();
            this.Opaque = false;
            UITapGestureRecognizer gestureRecognizer;
            gestureRecognizer = new UITapGestureRecognizer(this, @selector (singleTap:));
            this.AddGestureRecognizer(gestureRecognizer);
        }

        void SingleTap(UITapGestureRecognizer recognizer)
        {
            foreach (UIView v in this.Subviews)
            {
                if (v.IsKindOfClass(typeof(KxMenuView)) && v.RespondsToSelector(@selector (dismissMenu:)))
                {
                    v.PerformSelectorWithObject(@selector (dismissMenu:), @(true));
                }

            }
        }

    }

    @implementation KxMenuItem static instancetype MenuItemImageTargetAction(string title, UIImage image, object target, SEL action)
    {
        return new KxMenuItem(title, image, target, action);
    }

    KxMenu(string title, UIImage image, object target, SEL action)
    {
        NSParameterAssert(title.Length || image);
        this = base.init();
        if (this)
        {
            _title = title;
            _image = image;
            _target = target;
            _action = action;
        }

        return this;
    }

    bool Enabled()
    {
        return _target != null && _action != NULL;
    }

    void PerformAction()
    {
        __strong object target = this.Target;
        if (target && target.RespondsToSelector(_action))
        {
            target.PerformSelectorOnMainThreadWithObjectWaitUntilDone(_action, this, true);
        }

    }

    string Description()
    {
        return NSString.StringWithFormat("<%@ #%p %@>", typeof(this), this, _title);
    }

    @end
    public class KxMenuView : UIView
    {

        public public KxMenu()
            : base (CGRectZero)
        {
            this.BackgroundColor = UIColor.ClearColor();
            this.Opaque = true;
            this.Alpha = 0;
            this.Layer.ShadowOpacity = 0.5;
            this.Layer.ShadowOffset = CGSizeMake(2, 2);
            this.Layer.ShadowRadius = 2;
        }

        void SetupFrameInViewFromRect(UIView view, CGRect fromRect)
        {
            const CGSize contentSize = _contentView.Frame.Size;
            const CGFloat outerWidth = view.Bounds.Size.Width;
            const CGFloat outerHeight = view.Bounds.Size.Height;
            const CGFloat rectX0 = fromRect.Origin.X;
            const CGFloat rectX1 = fromRect.Origin.X + fromRect.Size.Width;
            const CGFloat rectXM = fromRect.Origin.X + fromRect.Size.Width * 0.5f;
            const CGFloat rectY0 = fromRect.Origin.Y;
            const CGFloat rectY1 = fromRect.Origin.Y + fromRect.Size.Height;
            const CGFloat rectYM = fromRect.Origin.Y + fromRect.Size.Height * 0.5f;
            ;
            const CGFloat widthPlusArrow = contentSize.Width + kArrowSize;
            const CGFloat heightPlusArrow = contentSize.Height + kArrowSize;
            const CGFloat widthHalf = contentSize.Width * 0.5f;
            const CGFloat heightHalf = contentSize.Height * 0.5f;
            const CGFloat kMargin = 5.f;
            if (heightPlusArrow < (outerHeight - rectY1))
            {
                _arrowDirection = KxMenuViewArrowDirection.Up;
                CGPoint point = (CGPoint) {rectXM - widthHalf, rectY1};
                if (point.X < kMargin) point.X = kMargin;

                if ((point.X + contentSize.Width + kMargin) > outerWidth) point.X = outerWidth - contentSize.Width - kMargin;

                _arrowPosition = rectXM - point.X;
                _contentView.Frame = (CGRect) {0, kArrowSize, contentSize};
                this.Frame = (CGRect) {point, contentSize.Width, contentSize.Height + kArrowSize};
            }
            else if (heightPlusArrow < rectY0)
            {
                _arrowDirection = KxMenuViewArrowDirection.Down;
                CGPoint point = (CGPoint) {rectXM - widthHalf, rectY0 - heightPlusArrow};
                if (point.X < kMargin) point.X = kMargin;

                if ((point.X + contentSize.Width + kMargin) > outerWidth) point.X = outerWidth - contentSize.Width - kMargin;

                _arrowPosition = rectXM - point.X;
                _contentView.Frame = (CGRect) {CGPointZero, contentSize};
                this.Frame = (CGRect) {point, contentSize.Width, contentSize.Height + kArrowSize};
            }
            else if (widthPlusArrow < (outerWidth - rectX1))
            {
                _arrowDirection = KxMenuViewArrowDirection.Left;
                CGPoint point = (CGPoint) {rectX1, rectYM - heightHalf};
                if (point.Y < kMargin) point.Y = kMargin;

                if ((point.Y + contentSize.Height + kMargin) > outerHeight) point.Y = outerHeight - contentSize.Height - kMargin;

                _arrowPosition = rectYM - point.Y;
                _contentView.Frame = (CGRect) {kArrowSize, 0, contentSize};
                this.Frame = (CGRect) {point, contentSize.Width + kArrowSize, contentSize.Height};
            }
            else if (widthPlusArrow < rectX0)
            {
                _arrowDirection = KxMenuViewArrowDirection.Right;
                CGPoint point = (CGPoint) {rectX0 - widthPlusArrow, rectYM - heightHalf};
                if (point.Y < kMargin) point.Y = kMargin;

                if ((point.Y + contentSize.Height + 5) > outerHeight) point.Y = outerHeight - contentSize.Height - kMargin;

                _arrowPosition = rectYM - point.Y;
                _contentView.Frame = (CGRect) {CGPointZero, contentSize};
                this.Frame = (CGRect) {point, contentSize.Width + kArrowSize, contentSize.Height};
            }
            else
            {
                _arrowDirection = KxMenuViewArrowDirection.None;
                this.Frame = (CGRect) {(outerWidth - contentSize.Width) * 0.5f, (outerHeight - contentSize.Height) * 0.5f, contentSize,};
            }

        }

        void ShowMenuInViewFromRectMenuItems(UIView view, CGRect rect, ArrayList menuItems)
        {
            _menuItems = menuItems;
            _contentView = this.MkContentView();
            this.AddSubview(_contentView);
            this.SetupFrameInViewFromRect(view, rect);
            KxMenuOverlay overlay = new KxMenuOverlay(view.Bounds);
            overlay.AddSubview(this);
            view.AddSubview(overlay);
            _contentView.Hidden = true;
            const CGRect toFrame = this.Frame;
            this.Frame = (CGRect) {this.ArrowPoint, 1, 1};
            UIView.AnimateWithDurationAnimationsCompletion(0.2, delegate(void)
            {
                this.Alpha = 1.0f;
                this.Frame = toFrame;
            }, delegate(bool completed)
            {
                _contentView.Hidden = false;
            });
        }

        void DismissMenu(bool animated)
        {
            if (this.Superview)
            {
                if (animated)
                {
                    _contentView.Hidden = true;
                    const CGRect toFrame = (CGRect) {this.ArrowPoint, 1, 1};
                    UIView.AnimateWithDurationAnimationsCompletion(0.2, delegate(void)
                    {
                        this.Alpha = 0;
                        this.Frame = toFrame;
                    }, delegate(bool finished)
                    {
                        if (this.Superview.IsKindOfClass(typeof(KxMenuOverlay))) this.Superview.RemoveFromSuperview();

                        this.RemoveFromSuperview();
                    });
                }
                else
                {
                    if (this.Superview.IsKindOfClass(typeof(KxMenuOverlay))) this.Superview.RemoveFromSuperview();

                    this.RemoveFromSuperview();
                }

            }

        }

        void PerformAction(object sender)
        {
            this.DismissMenu(true);
            UIButton button = (UIButton)sender;
            KxMenuItem menuItem = _menuItems[button.Tag];
            menuItem.PerformAction();
        }

        UIView MkContentView()
        {
            foreach (UIView v in this.Subviews)
            {
                v.RemoveFromSuperview();
            }
            if (!_menuItems.Count) return null;

            const CGFloat kMinMenuItemHeight = 32.f;
            const CGFloat kMinMenuItemWidth = 32.f;
            const CGFloat kMarginX = 10.f;
            const CGFloat kMarginY = 5.f;
            UIFont titleFont = KxMenu.TitleFont();
            if (!titleFont) titleFont = UIFont.BoldSystemFontOfSize(16);

            CGFloat maxImageWidth = 0;
            CGFloat maxItemHeight = 0;
            CGFloat maxItemWidth = 0;
            foreach (KxMenuItem menuItem in _menuItems)
            {
                const CGSize imageSize = menuItem.Image.Size;
                if (imageSize.Width > maxImageWidth) maxImageWidth = imageSize.Width;

            }
            if (maxImageWidth)
            {
                maxImageWidth += kMarginX;
            }

            foreach (KxMenuItem menuItem in _menuItems)
            {
                const CGSize titleSize = menuItem.Title.SizeWithFont(titleFont);
                const CGSize imageSize = menuItem.Image.Size;
                const CGFloat itemHeight = Math.Max(titleSize.Height, imageSize.Height) + kMarginY * 2;
                const CGFloat itemWidth = ((!menuItem.Enabled && !menuItem.Image) ? titleSize.Width : maxImageWidth + titleSize.Width) + kMarginX * 4;
                if (itemHeight > maxItemHeight) maxItemHeight = itemHeight;

                if (itemWidth > maxItemWidth) maxItemWidth = itemWidth;

            }
            maxItemWidth = Math.Max(maxItemWidth, kMinMenuItemWidth);
            maxItemHeight = Math.Max(maxItemHeight, kMinMenuItemHeight);
            const CGFloat titleX = kMarginX * 2 + maxImageWidth;
            const CGFloat titleWidth = maxItemWidth - titleX - kMarginX * 2;
            UIImage selectedImage = KxMenuView.SelectedImage((CGSize) {maxItemWidth, maxItemHeight + 2});
            UIImage gradientLine = KxMenuView.GradientLine((CGSize) {maxItemWidth - kMarginX * 4, 1});
            UIView contentView = new UIView(CGRectZero);
            contentView.AutoresizingMask = UIViewAutoresizingNone;
            contentView.BackgroundColor = UIColor.ClearColor();
            contentView.Opaque = false;
            CGFloat itemY = kMarginY * 2;
            uint itemNum = 0;
            foreach (KxMenuItem menuItem in _menuItems)
            {
                const CGRect itemFrame = (CGRect) {0, itemY, maxItemWidth, maxItemHeight};
                UIView itemView = new UIView(itemFrame);
                itemView.AutoresizingMask = UIViewAutoresizingNone;
                itemView.BackgroundColor = UIColor.ClearColor();
                itemView.Opaque = false;
                contentView.AddSubview(itemView);
                if (menuItem.Enabled)
                {
                    UIButton button = UIButton.ButtonWithType(UIButtonTypeCustom);
                    button.Tag = itemNum;
                    button.Frame = itemView.Bounds;
                    button.Enabled = menuItem.Enabled;
                    button.BackgroundColor = UIColor.ClearColor();
                    button.Opaque = false;
                    button.AutoresizingMask = UIViewAutoresizingNone;
                    button.AddTargetActionForControlEvents(this, @selector (performAction:), UIControlEventTouchUpInside);
                    button.SetBackgroundImageForState(selectedImage, UIControlStateHighlighted);
                    itemView.AddSubview(button);
                }

                if (menuItem.Title.Length)
                {
                    CGRect titleFrame;
                    if (!menuItem.Enabled && !menuItem.Image)
                    {
                        titleFrame = (CGRect) {kMarginX * 2, kMarginY, maxItemWidth - kMarginX * 4, maxItemHeight - kMarginY * 2};
                    }
                    else
                    {
                        titleFrame = (CGRect) {titleX, kMarginY, titleWidth, maxItemHeight - kMarginY * 2};
                    }

                    UILabel titleLabel = new UILabel(titleFrame);
                    titleLabel.Text = menuItem.Title;
                    titleLabel.Font = titleFont;
                    titleLabel.TextAlignment = menuItem.Alignment;
                    titleLabel.TextColor = menuItem.ForeColor ? menuItem.ForeColor : UIColor.WhiteColor();
                    titleLabel.BackgroundColor = UIColor.ClearColor();
                    titleLabel.AutoresizingMask = UIViewAutoresizingNone;
                    itemView.AddSubview(titleLabel);
                }

                if (menuItem.Image)
                {
                    const CGRect imageFrame = {kMarginX * 2, kMarginY, maxImageWidth, maxItemHeight - kMarginY * 2};
                    UIImageView imageView = new UIImageView(imageFrame);
                    imageView.Image = menuItem.Image;
                    imageView.ClipsToBounds = true;
                    imageView.ContentMode = UIViewContentModeCenter;
                    imageView.AutoresizingMask = UIViewAutoresizingNone;
                    itemView.AddSubview(imageView);
                }

                if (itemNum < _menuItems.Count - 1)
                {
                    UIImageView gradientView = new UIImageView(gradientLine);
                    gradientView.Frame = (CGRect) {kMarginX * 2, maxItemHeight + 1, gradientLine.Size};
                    gradientView.ContentMode = UIViewContentModeLeft;
                    itemView.AddSubview(gradientView);
                    itemY += 2;
                }

                itemY += maxItemHeight;
                ++itemNum;
            }
            contentView.Frame = (CGRect) {0, 0, maxItemWidth, itemY + kMarginY * 2};
            return contentView;
        }

        CGPoint ArrowPoint()
        {
            CGPoint point;
            if (_arrowDirection == KxMenuViewArrowDirection.Up)
            {
                point = (CGPoint) {CGRectGetMinX(this.Frame) + _arrowPosition, CGRectGetMinY(this.Frame)};
            }
            else if (_arrowDirection == KxMenuViewArrowDirection.Down)
            {
                point = (CGPoint) {CGRectGetMinX(this.Frame) + _arrowPosition, CGRectGetMaxY(this.Frame)};
            }
            else if (_arrowDirection == KxMenuViewArrowDirection.Left)
            {
                point = (CGPoint) {CGRectGetMinX(this.Frame), CGRectGetMinY(this.Frame) + _arrowPosition};
            }
            else if (_arrowDirection == KxMenuViewArrowDirection.Right)
            {
                point = (CGPoint) {CGRectGetMaxX(this.Frame), CGRectGetMinY(this.Frame) + _arrowPosition};
            }
            else
            {
                point = this.Center;
            }

            return point;
        }

        static UIImage SelectedImage(CGSize size)
        {
            const CGFloat[] locations = {0, 1};
            const CGFloat[] components = {0.216, 0.471, 0.871, 1, 0.059, 0.353, 0.839, 1,};
            return this.GradientImageWithSizeLocationsComponentsCount(size, locations, components, 2);
        }

        static UIImage GradientLine(CGSize size)
        {
            const CGFloat[] locations = {0, 0.2, 0.5, 0.8, 1};
            const CGFloat R = 0.44f, G = 0.44f, B = 0.44f;
            const CGFloat[] components = {R, G, B, 0.1, R, G, B, 0.4, R, G, B, 0.7, R, G, B, 0.4, R, G, B, 0.1};
            return this.GradientImageWithSizeLocationsComponentsCount(size, locations, components, 5);
        }

        static UIImage GradientImageWithSizeLocationsComponentsCount(CGSize size, CGFloat[] locations, CGFloat[] components, uint count)
        {
            UIGraphicsBeginImageContextWithOptions(size, false, 0);
            CGContextRef context = UIGraphicsGetCurrentContext();
            CGColorSpaceRef colorSpace = CGColorSpaceCreateDeviceRGB();
            CGGradientRef colorGradient = CGGradientCreateWithColorComponents(colorSpace, components, locations, 2);
            CGColorSpaceRelease (colorSpace);
            CGContextDrawLinearGradient(context, colorGradient, (CGPoint) {0, 0}, (CGPoint) {size.Width, 0}, 0);
            CGGradientRelease (colorGradient);
            UIImage image = UIGraphicsGetImageFromCurrentImageContext();
            UIGraphicsEndImageContext();
            return image;
        }

        void DrawRect(CGRect rect)
        {
            this.DrawBackgroundInContext(this.Bounds, UIGraphicsGetCurrentContext());
        }

        void DrawBackgroundInContext(CGRect frame, CGContextRef context)
        {
            CGFloat R0 = 0.267, G0 = 0.303, B0 = 0.335;
            CGFloat R1 = 0.040, G1 = 0.040, B1 = 0.040;
            UIColor tintColor = KxMenu.TintColor();
            if (tintColor)
            {
                CGFloat a;
                tintColor.GetRedGreenBlueAlpha(R0, G0, B0, a);
            }

            CGFloat X0 = frame.Origin.X;
            CGFloat X1 = frame.Origin.X + frame.Size.Width;
            CGFloat Y0 = frame.Origin.Y;
            CGFloat Y1 = frame.Origin.Y + frame.Size.Height;
            UIBezierPath arrowPath = UIBezierPath.BezierPath();
            const CGFloat kEmbedFix = 3.f;
            if (_arrowDirection == KxMenuViewArrowDirection.Up)
            {
                const CGFloat arrowXM = _arrowPosition;
                const CGFloat arrowX0 = arrowXM - kArrowSize;
                const CGFloat arrowX1 = arrowXM + kArrowSize;
                const CGFloat arrowY0 = Y0;
                const CGFloat arrowY1 = Y0 + kArrowSize + kEmbedFix;
                arrowPath.MoveToPoint((CGPoint) {arrowXM, arrowY0});
                arrowPath.AddLineToPoint((CGPoint) {arrowX1, arrowY1});
                arrowPath.AddLineToPoint((CGPoint) {arrowX0, arrowY1});
                arrowPath.AddLineToPoint((CGPoint) {arrowXM, arrowY0});
                UIColor.ColorWithRedGreenBlueAlpha(R0, G0, B0, 1).Set();
                Y0 += kArrowSize;
            }
            else if (_arrowDirection == KxMenuViewArrowDirection.Down)
            {
                const CGFloat arrowXM = _arrowPosition;
                const CGFloat arrowX0 = arrowXM - kArrowSize;
                const CGFloat arrowX1 = arrowXM + kArrowSize;
                const CGFloat arrowY0 = Y1 - kArrowSize - kEmbedFix;
                const CGFloat arrowY1 = Y1;
                arrowPath.MoveToPoint((CGPoint) {arrowXM, arrowY1});
                arrowPath.AddLineToPoint((CGPoint) {arrowX1, arrowY0});
                arrowPath.AddLineToPoint((CGPoint) {arrowX0, arrowY0});
                arrowPath.AddLineToPoint((CGPoint) {arrowXM, arrowY1});
                UIColor.ColorWithRedGreenBlueAlpha(R1, G1, B1, 1).Set();
                Y1 -= kArrowSize;
            }
            else if (_arrowDirection == KxMenuViewArrowDirection.Left)
            {
                const CGFloat arrowYM = _arrowPosition;
                const CGFloat arrowX0 = X0;
                const CGFloat arrowX1 = X0 + kArrowSize + kEmbedFix;
                const CGFloat arrowY0 = arrowYM - kArrowSize;
                ;
                const CGFloat arrowY1 = arrowYM + kArrowSize;
                arrowPath.MoveToPoint((CGPoint) {arrowX0, arrowYM});
                arrowPath.AddLineToPoint((CGPoint) {arrowX1, arrowY0});
                arrowPath.AddLineToPoint((CGPoint) {arrowX1, arrowY1});
                arrowPath.AddLineToPoint((CGPoint) {arrowX0, arrowYM});
                UIColor.ColorWithRedGreenBlueAlpha(R0, G0, B0, 1).Set();
                X0 += kArrowSize;
            }
            else if (_arrowDirection == KxMenuViewArrowDirection.Right)
            {
                const CGFloat arrowYM = _arrowPosition;
                const CGFloat arrowX0 = X1;
                const CGFloat arrowX1 = X1 - kArrowSize - kEmbedFix;
                const CGFloat arrowY0 = arrowYM - kArrowSize;
                ;
                const CGFloat arrowY1 = arrowYM + kArrowSize;
                arrowPath.MoveToPoint((CGPoint) {arrowX0, arrowYM});
                arrowPath.AddLineToPoint((CGPoint) {arrowX1, arrowY0});
                arrowPath.AddLineToPoint((CGPoint) {arrowX1, arrowY1});
                arrowPath.AddLineToPoint((CGPoint) {arrowX0, arrowYM});
                UIColor.ColorWithRedGreenBlueAlpha(R1, G1, B1, 1).Set();
                X1 -= kArrowSize;
            }

            arrowPath.Fill();
            const CGRect bodyFrame = {X0, Y0, X1 - X0, Y1 - Y0};
            UIBezierPath borderPath = UIBezierPath.BezierPathWithRoundedRectCornerRadius(bodyFrame, 8);
            const CGFloat[] locations = {0, 1};
            const CGFloat[] components = {R0, G0, B0, 1, R1, G1, B1, 1,};
            CGColorSpaceRef colorSpace = CGColorSpaceCreateDeviceRGB();
            CGGradientRef gradient = CGGradientCreateWithColorComponents(colorSpace, components, locations, sizeof (locations) / sizeof locations[0]);
            CGColorSpaceRelease (colorSpace);
            borderPath.AddClip();
            CGPoint start, end;
            if (_arrowDirection == KxMenuViewArrowDirection.Left || _arrowDirection == KxMenuViewArrowDirection.Right)
            {
                start = (CGPoint) {X0, Y0};
                end = (CGPoint) {X1, Y0};
            }
            else
            {
                start = (CGPoint) {X0, Y0};
                end = (CGPoint) {X0, Y1};
            }

            CGContextDrawLinearGradient(context, gradient, start, end, 0);
            CGGradientRelease (gradient);
        }

    }
    public class KxMenu
    {
        protected KxMenuView _menuView;
        protected bool _observing;
        static instancetype SharedMenu()
        {
            static dispatch_once_t onceToken;
            dispatch_once(onceToken, delegate()
            {
                gMenu = new KxMenu();
            });
            return gMenu;
        }

        public public KxMenu()
        {
            NSAssert(!gMenu, "singleton object");
            this = base.init();
            if (this)
            {
            }

            return this;
        }

        void Dealloc()
        {
            if (_observing)
            {
                NSNotificationCenter.DefaultCenter().RemoveObserver(this);
            }

        }

        void ShowMenuInViewFromRectMenuItems(UIView view, CGRect rect, ArrayList menuItems)
        {
            NSParameterAssert (view);
            NSParameterAssert(menuItems.Count);
            if (_menuView)
            {
                _menuView.DismissMenu(false);
                _menuView = null;
            }

            if (!_observing)
            {
                _observing = true;
                NSNotificationCenter.DefaultCenter().AddObserverSelectorNameTheObject(this, @selector (orientationWillChange:), UIApplicationWillChangeStatusBarOrientationNotification, null);
            }

            _menuView = new KxMenuView();
            _menuView.ShowMenuInViewFromRectMenuItems(view, rect, menuItems);
        }

        void DismissMenu()
        {
            if (_menuView)
            {
                _menuView.DismissMenu(false);
                _menuView = null;
            }

            if (_observing)
            {
                _observing = false;
                NSNotificationCenter.DefaultCenter().RemoveObserver(this);
            }

        }

        void OrientationWillChange(NSNotification n)
        {
            this.DismissMenu();
        }

        static void ShowMenuInViewFromRectMenuItems(UIView view, CGRect rect, ArrayList menuItems)
        {
            this.SharedMenu().ShowMenuInViewFromRectMenuItems(view, rect, menuItems);
        }

        static void DismissMenu()
        {
            this.SharedMenu().DismissMenu();
        }

        static UIColor TintColor()
        {
            return gTintColor;
        }

        static void SetTintColor(UIColor tintColor)
        {
            if (tintColor != gTintColor)
            {
                gTintColor = tintColor;
            }

        }

        static UIFont TitleFont()
        {
            return gTitleFont;
        }

        static void SetTitleFont(UIFont titleFont)
        {
            if (titleFont != gTitleFont)
            {
                gTitleFont = titleFont;
            }

        }

    }
}
