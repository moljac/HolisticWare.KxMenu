using System;
using UIKit;
using Foundation;

namespace KxMenu {
    
    
    internal class KxMenu
    {
        
        #region Constructors
        public KxMenu() {
            // {
            //     NSAssert(!gMenu, @"singleton object");
            //     
            //     this = [super init];
            //     if (this) {
            //     }
            //     return this;
            // }
        }
        #endregion
        
        #region Methods
        private void Dealloc() {
            // 
            // {
            //     if (_observing) {        
            //         [[NSNotificationCenter defaultCenter] removeObserver:this];
            //     }
            // }
        }
        
        private void ShowMenuInView(UIView view) {
            // 
            //                fromRect:(CGRect)rect
        }
        
        private void DismissMenu() {
            // 
            // {
            //     if (_menuView) {
            //         
            //         [_menuView dismissMenu:NO];
            //         _menuView = null;
            //     }
            //     
            //     if (_observing) {
            //         
            //         _observing = false;
            //         [[NSNotificationCenter defaultCenter] removeObserver:this];
            //     }
            // }
        }
        
        private void OrientationWillChange(NSNotification n) {
            // 
            // {
            //     [this dismissMenu];
            // }
        }
        #endregion
        
        #region Static Methods
        public static instancetype SharedMenu() {
            // 
            // {
            //     static dispatch_once_t onceToken;
            //     dispatch_once(&onceToken, ^{
            //         
            //         gMenu = [[KxMenu alloc] init];
            //     });
            //     return gMenu;
            // }
        }
        
        public static void ShowMenuInView(UIView view) {
            // 
            //                fromRect:(CGRect)rect
        }
        
        public static void DismissMenu() {
            // 
            // {
            //     [[this sharedMenu] dismissMenu];
            // }
        }
        
        public static UIColor TintColor() {
            // 
            // {
            //     return gTintColor;
            // }
        }
        
        public static void SetTintColor(UIColor tintColor) {
            // 
            // {
            //     if (tintColor != gTintColor) {
            //         gTintColor = tintColor;
            //     }
            // }
        }
        
        public static UIFont TitleFont() {
            // 
            // {
            //     return gTitleFont;
            // }
        }
        
        public static void SetTitleFont(UIFont titleFont) {
            // 
            // {
            //     if (titleFont != gTitleFont) {
            //         gTitleFont = titleFont;
            //     }
            // }
        }
        #endregion
    }
}
