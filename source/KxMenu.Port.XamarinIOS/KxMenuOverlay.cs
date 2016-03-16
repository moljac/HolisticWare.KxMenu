using System;
using CoreGraphics;
using UIKit;

namespace KxMenu {
    
    
    internal class KxMenuOverlay {
        
        #region Constructors
        public KxMenuOverlay(CGRect frame) {
            // {
            //     this = [super initWithFrame:frame];
            //     if (this) {
            //         this.BackgroundColor = UIColor.Clear;
            //         this.opaque = false;
            //         
            //         UITapGestureRecognizer gestureRecognizer;
            //         gestureRecognizer = [[UITapGestureRecognizer alloc] initWithTarget:this
            //                                                                     action:@selector(singleTap:)];
            //         [this addGestureRecognizer:gestureRecognizer];
            //     }
            //     return this;
            // }
        }
        #endregion
        
        #region Methods
        private void SingleTap(UITapGestureRecognizer recognizer) {
            // 
            // {
            //     for (UIView v in this.subviews) {
            //         if ([v isKindOfClass:[KxMenuView class]] && [v respondsToSelector:@selector(dismissMenu:)]) {
            //             [v performSelector:@selector(dismissMenu:) withObject:@(YES)];
            //         }
            //     }
            // }
        }
        #endregion
    }
}
