using System;
#if ! __CLASSIC__
using ObjCRuntime;
#else
using MonoTouch.ObjCRuntime;
#endif

[assembly: LinkWith 
			(
				"libKxMenu.a", 
				LinkTarget.ArmV7 
				| 
				LinkTarget.Arm64
				| 
				LinkTarget.Simulator 
				| 
				LinkTarget.Simulator64 
				, 
				SmartLink = true, 
				ForceLoad = true
			)
]
