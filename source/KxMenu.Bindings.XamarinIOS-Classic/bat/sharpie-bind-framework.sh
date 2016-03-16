#!/bin/bash

. ./project-binding-specific-data.sh

$SHARPIE --help

pwd

ls -al@ $DIR_HEADERS/*.h

$SHARPIE xcode -help

$SHARPIE xcode -sdks

$XCODEBUILD -showsdks


# https://forums.xamarin.com/discussion/31184/binding-third-party-ios-framework-using-objective-sharpie

$SHARPIE \
		bind \
        -verbose \
        -output ./generated-framework/ \
	    -sdk $IOS_SDK \
	    -framework \
			$DIR_FRAMEWORK


