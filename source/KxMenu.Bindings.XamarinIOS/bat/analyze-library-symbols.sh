#!/bin/bash

LIBRARY=../lib/LayerKit.a
CLASS=ILYRQueryable

nm -g $LIBRARY | grep $CLASS.o
