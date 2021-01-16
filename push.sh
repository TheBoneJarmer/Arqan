#!/bin/bash

# Get data from git
BRANCH="`git branch --show-current`"
FILES="`ls *.nupkg`"

# Determine if to push and to where
if [ $BRANCH = "main" ]
then
   	echo "Pushing to nuget.org"
	
	for PKG in $FILES
	do
		echo "Pushing package $PKG"
		dotnet nuget push $PKG -s nuget.org -k $NUGET_API_KEY
	done
	
	exit
fi

if [ $BRANCH = "develop" ]
then
	echo "Pushing to github"

	for PKG in $FILES
	do
		echo "Pushing package $PKG"
		dotnet nuget push $PKG -s github
	done
	
	exit
fi

echo "Pushing package not allowed on branch $BRANCH"
exit 1
