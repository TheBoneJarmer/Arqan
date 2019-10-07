@echo off

C:\Sdk\Dotnet\3.0.100\dotnet publish -c Release -r win-x64 -o tools /p:PublishSingleFile=true ./src-tools/generator/Generator.csproj
