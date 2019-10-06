# TilarGL
TilarGL is a classlib which basically serves as a C# wrapper for OpenGL functions and enums as well as GLFW functions and enums.

## Important note
As you can see there are just bash scripts in the repository. Please forgive me if you are a Windows user, I have not had the chance yet to provide myself with a Windows computer in order to give 
you batch files as alternative.

## Installation
TilarGL does not have a NuGet library available yet. Once I feel like the library has reached a solid state, I will start pushing packages. For now, just refer to the DLL file in your project.

## Building

### Requirements
To build this library you need dotnet core 2.1 or newer. I recommend going with the latest version when possible.

### Sources
Instead of having a solution file with several class libraries added to it, which each contains more or less the same content, I decided to use one 'base' source, which contains all C# class files with
placholders. This repository contains a tool to generate the actual source for you. From there on, you can use the dotnet cli to do whatever you want. The reason why I did it is to prevent having to
maintain multiple library projects for multiple operating systems with code that is like 95% similar. Now I need to modify only one source and let the generator do everything else for me.

### Step-By-Step
Without further ado, this is how you build the project:

* Run ./init on Linux or ./init.cmd on Windows to build the tools and setup your workspace.
* Run ./generate on Linux or ./generate.cmd on Windows to generate an entire solution from the 'src-base' folder.
* Now cd into the 'src-tilargl' folder and use the dotnet cli the build the solution

## Usage
After succesfully building the library, you will have a DLL file which you can refer to in your projects. However, that is not enough. You will need to make sure you got the right dependencies in place.

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
#### Windows
You can just download the pre-compiled binaries from https://www.glfw.org/download.html.

#### Linux
The developers did not provide a pre-compiled library for Linux because that would not be applicable for all distros. However, on some distros glfw can be installed from your package repository.
 To install glfw on Ubuntu for example, run the following commands:

```bash
sudo apt-get update
sudo apt-get install libglfw3 libglfw3-dev
```

## Contributing
I would highly appreciate it if you would help me polish this library. I have not had the chance yet to test all wrapped methods in the classes. I actually generated
them based on an XML provided by the Khronos Group a couple of years ago. So probably there are new functions and enums already which have not been integrated yet. So feel free to send in a pull request!

## License
[MIT](https://choosealicense.com/licenses/mit/)
