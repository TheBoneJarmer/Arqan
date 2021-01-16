#!/bin/bash

rm *.nupkg &> /dev/null
echo "Building package"
dotnet pack -c x64 -o . src/Arqan/*.csproj
dotnet pack -c x86 -o . src/Arqan/*.csproj
