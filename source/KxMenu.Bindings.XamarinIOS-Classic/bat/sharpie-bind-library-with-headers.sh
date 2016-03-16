#!/bin/bash

. ./project-binding-specific-data.sh

$SHARPIE --help

pwd

ls -al@ $DIR_HEADERS/*.h

$SHARPIE xcode -help

$SHARPIE xcode -sdks

$XCODEBUILD -showsdks


$SHARPIE \
        bind \
        -verbose \
        -output ./generated-library-with-headers/ \
        -scope \
             $DIR_HEADERS \
             $FILE_HEADER_UMBRELLA \
        -sdk $IOO_SDK \
        -c \
            -I$DIR_HEADERS \
            -arch $ARCH 


