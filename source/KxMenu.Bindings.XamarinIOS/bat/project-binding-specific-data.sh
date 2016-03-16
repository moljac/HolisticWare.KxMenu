#!/bin/bash

export XBUILD=xbuild
export MDTOOL="/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool"
export XCODEBUILD=xcodebuild

export SHARPIE=sharpie
export PROJECT=Xamarin.Ooyala.Bindings.XamarinIOS.csproj

export DIR_HEADERS=../../../external/binaries-xtensive/brightcove-player-sdk-ios-4.3.5/Headers
export FILE_HEADER_UMBRELLA=../../../external/binaries-xtensive//brightcove-player-sdk-ios-4.3.5/Headers/Brightcove.h

export DIR_FRAMEWORK=../../../external/binaries-xtensive/brightcove-player-sdk-ios-4.3.5/Library

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
IOS_SDK=iphoneos8.4
ARCH=arm64


echo ===================================================================================
echo SHARPIE=$SHARPIE
echo XBUILD=$XBUILD
echo MDTOOL=$MDTOOL

echo IOS_SDK=$IOS_SDK
echo -----------------------------------------------------------------------------------