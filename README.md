# Arqan
Arqan is a .NET library which basically serves as a C# wrapper for OpenGL functions and enums as well as GLFW functions and enums.

## Installation
Due to the differences between how OpenGL works per operating system I maintain two versions of Arqan. One for Windows and one for Linux. OSX support has been implemented by user MythicalSora but because I do not own a MacBook I cannot officially build and publish NuGet packages for it.

```
dotnet add package Arqan.Windows
dotnet add package Arqan.Linux
```

### Cross-Platform usage
Instead of maintaining multiple code sources with each different package references I recommend making use of the Condition attribute in the ItemGroup element of your csproj file like this:

```
<PropertyGroup Condition="$([System.Runtime.InteropServices.RuntimeInformation]::IsOSPlatform($([System.Runtime.InteropServices.OSPlatform]::Linux)))">
    <PackageReference Include="Arqan.Linux" Version="2.3.0" />
</ItemGroup>
<PropertyGroup Condition="$([System.Runtime.InteropServices.RuntimeInformation]::IsOSPlatform($([System.Runtime.InteropServices.OSPlatform]::OSX)))">
    <PackageReference Include="Arqan.OSX" Version="2.3.0" />
</ItemGroup>
<ItemGroup Condition="'$(OS)' == 'Windows_NT'">
    <PackageReference Include="Arqan.Windows.x64" Version="2.3.0" />
</ItemGroup>
```

## Building

### Requirements
To build this library you need dotnet core 2.1 or newer. I recommend going with the latest version when possible.

## Usage

```C#
GL.glColorMask();
GL.glFlush();
GL.glCreateProgram();
GLFW.glfwInit();
```

## Dependencies
Just refering the library wont cut it. You also need to make sure you got the right 3rd-party libraries.

### OpenGL
#### Windows
Most Windows system ship a dll called "opengl32.dll". If not, make sure your hardware supports OpenGL and that your drivers are up-to-date.

#### Linux
I cannot provide instructions for all distros because I don't know all of them. Nor would that be doable. So I just go along with the most popular one, which in this case is Ubuntu. Run below commands to
install OpenGL on your system, if you have not done so already.

```bash
sudo apt-get update
sudo apt-get install libglu1-mesa-dev freeglut3-dev mesa-common-dev
```

### GLFW
Arqan supports GLFW version 3.3.2 and higher. For the current installation of that version see the instructions below as it differs per operating system.

#### Windows
I included the pre-compiled glfw3 dll files so you won't have to add those manually. You _do not_ need to manually copy and paste it in your bin folder. The dll file is included in the nuget package and will be copied to your output folder upon building your application.

#### Linux
The developers did not provide a pre-compiled library for Linux because that would not be appliable for all distros. So by default they suggest to compile the library on your machine using cmake. A tutorial on how to do this can be found at https://www.glfw.org/docs/latest/compile.html.
However, on some distros glfw can be installed from your package repository. To install glfw on Ubuntu for example, run the following commands:

```bash
sudo apt-get update
sudo apt-get install libglfw3 libglfw3-dev
```

## Contributing
I would highly appreciate it if you would help me polish this library. I have not had the chance yet to test all wrapped methods in the classes. I actually generated
them based on an XML provided by the Khronos Group a couple of years ago. So probably there are new functions and enums already which have not been integrated yet. Therefore feel free to open up a pull request anytime.

> I am following the GitFlow model so please use the **develop** branch as both **source** and **target** branch. Do **not** work directly on the _main_ branch.

## Credits
* First of all a special thanks to user [MythicalSora](https://github.com/MythicalSora) who has been so nice of making Arqan compatible with OSX. I can't as I don't use or own a MacBook for that matter.

## License
[MIT](https://choosealicense.com/licenses/mit/)
