#!/bin/bash

. ./project-binding-specific-data.sh

$SHARPIE --help

pwd

ls -al@ $DIR_HEADERS/*.h

$SHARPIE xcode -help

$SHARPIE xcode -sdks

$XCODEBUILD -showsdks


# https://forums.xamarin.com/discussion/31184/binding-third-party-ios-framework-using-objective-sharpie
sharpie \
		bind \
        -verbose \
        -output ./generated-framework-with-headers/ \
	    -sdk iphoneos8.3 \
	    -scope \
             $DIR_FRAMEWORK \
             $FILE_HEADER_UMBRELLA \
		    -c \
		    	-F \
		    	.