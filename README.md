# Arqan
Arqan is a classlib which basically serves as a C# wrapper for OpenGL functions and enums as well as GLFW 3.3.2 functions and enums.

## Installation
Due to the differences between how OpenGL works per operating system I maintain two versions of Arqan. One for Windows and one for Linux. And for Windows I maintain a version per architecture. See the commands below.

```
dotnet add package Arqan.Windows.x64
dotnet add package Arqan.Windows.x86
dotnet add package Arqan.Linux
```

### Cross-Platform usage
Instead of maintaining multiple code sources with each different package references I recommend making use of the Condition attribute in the ItemGroup element of your csproj file like this:

```
<ItemGroup Condition="'$(OS)' == 'UNIX'">
    <PackageReference Include="Arqan.Linux" Version="2.1.0" />
</ItemGroup>
<ItemGroup Condition="'$(OS)' == 'Windows_NT'">
    <PackageReference Include="Arqan.Windows.x64" Version="2.1.0" Condition="'$(Configuration)' == 'x64'" />
    <PackageReference Include="Arqan.Windows.x86" Version="2.1.0" Condition="'$(Configuration)' == 'x86'" />
</ItemGroup>
```

This way you could build your application using the command **dotnet build -c x64** or **dotnet build -c x86** if you are targeting _Windows_ or simply **dotnet build** if you are targeting _Linux_.

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
Arqan supports GLFW version 3.3.2. For the current installation of that version see the instructions below as it differs per operating system.

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
them based on an XML provided by the Khronos Group a couple of years ago. So probably there are new functions and enums already which have not been integrated yet. So feel free to send in a pull request or open up an issue.

### GitFlow branching model
I make use of the **GitFlow branching model** in all of my repositories. Please use it if you send in pull requests. Arqan is being built by my own TeamCity server instance, which is configured to respect the GitFlow branching model. If you use a branch name that does not follow the model **the build will fail or simply not start**. Therefore I would like to ask to name your branch like this:

> feature/#issue number#

Where the _#issue number#_ represents the issue number on GitHub. Also please keep all your branch names in **lowercase**. This way the repository will be kept clean and structured.

## License
[MIT](https://choosealicense.com/licenses/mit/)
