#!/bin/bash

export XBUILD=xbuild
export MDTOOL="/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool"
export XCODEBUILD=xcodebuild

export SHARPIE=sharpie
export PROJECT=Layer.Bindings.XamarinIOS.csproj

export DIR_HEADERS=../../../external/quick-start-ios/Pods/LayerKit/LayerKit.embeddedframework/LayerKit.framework/Headers/
export FILE_HEADER_UMBRELLA=../../../external/quick-start-ios/Pods/LayerKit/LayerKit.embeddedframework/LayerKit.framework/Headers/LayerKit.h 

export DIR_FRAMEWORK=../../../external/quick-start-ios/Pods/LayerKit/LayerKit.embeddedframework/LayerKit.framework/


# xcodebuild -showsdks
# OS X SDKs:
# 	OS X 10.9                     	-sdk macosx10.9
# 	OS X 10.10                    	-sdk macosx10.10
# 
# iOS SDKs:
# 	iOS 8.3                       	-sdk iphoneos8.3
# 
# iOS Simulator SDKs:
# 	Simulator - iOS 8.3           	-sdk iphonesimulator8.3
IOS_SDK=iphoneos8.3
ARCH=arm64


echo ===================================================================================
echo SHARPIE=$SHARPIE
echo XBUILD=$XBUILD
echo MDTOOL=$MDTOOL

echo IOS_SDK=$IOS_SDK
echo -----------------------------------------------------------------------------------