using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (RequestsHelp(args) || args.Length == 0 || args.Length < 2)
            {
                DisplayHelp();
                return;
            }

            Init(args);
            Run(args);
        }

        static void Init(string[] args)
        {
            var srcdir = args[0];
            var destdir = args[1];
            var deleteDestDir = args.Any(x => x == "-d");

            // Perform some checks
            if (!Directory.Exists(srcdir))
            {
                Console.Error.WriteLine("Source directory not found");
                Environment.Exit(1);
            }

            // Delete the dest dir if requested or throw an error if it exists
            if (Directory.Exists(destdir))
            {
                if (deleteDestDir)
                {
                    Directory.Delete(destdir, true);
                }
                else
                {
                    Console.Error.WriteLine("Destination directory already exists");
                    Environment.Exit(2);
                }
            }
        }

        static void Run(string[] args)
        {
            var srcdir = args[0];
            var destdir = args[1];

            // Create all directories
            Console.WriteLine("Creating destination directories");
            Directory.CreateDirectory(destdir);            
            Directory.CreateDirectory(destdir + "/windows");
            Directory.CreateDirectory(destdir + "/linux");

            // Generate the source
            Console.WriteLine("Creating library project for Linux");
            GenerateProjectFile(destdir + "/linux");

            Console.WriteLine("Copying all files for Linux");
            GenerateSourceFiles(srcdir, destdir, SupportedOperatingSystem.Linux);

            Console.WriteLine("Creating library project for Windows");
            GenerateProjectFile(destdir + "/windows");

            Console.WriteLine("Copying all files for Windows");
            GenerateSourceFiles(srcdir, destdir, SupportedOperatingSystem.Windows);

            Console.WriteLine("Done");
        }

        static void GenerateProjectFile(string path)
        {
            // Generate the csproj file
            var writer = new StreamWriter(path + "/TilarGL.csproj");

            writer.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
            writer.WriteLine();
            writer.WriteLine("\t<PropertyGroup>");
            writer.WriteLine("\t\t<AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
            writer.WriteLine("\t\t<TargetFramework>netstandard2.0</TargetFramework>");
            writer.WriteLine("\t</PropertyGroup>");
            writer.WriteLine();
            writer.WriteLine("</Project>");

            writer.Close();
        }
        static void GenerateSourceFiles(string srcdir, string destdir, SupportedOperatingSystem os)
        {
            var files = Directory.GetFiles(srcdir);

            // Copy all of them except for os-specific files that are not part of the current selected os
            foreach (var file in files)
            {
                var filename = GetFileName(file);

                if (os == SupportedOperatingSystem.Linux && filename == "WGL.cs")
                {
                    continue;
                }
                if (os == SupportedOperatingSystem.Windows && filename == "GLX.cs")
                {
                    continue;
                }

                if (os == SupportedOperatingSystem.Linux)
                {
                    GenerateSourceFile(file, destdir + "/linux/" + filename, os);
                }
                if (os == SupportedOperatingSystem.Windows)
                {
                    GenerateSourceFile(file, destdir + "/windows/" + filename, os);
                }
            }
        }
        static void GenerateSourceFile(string src, string dest, SupportedOperatingSystem os)
        {
            var contents = File.ReadAllText(src);

            // Replace placeholders within the content
            if (os == SupportedOperatingSystem.Linux)
            {
                contents = contents.Replace("<LIB_OPENGL>", "\"libGL.so\"");
                contents = contents.Replace("<LIB_GLFW>", "\"libglfw.so\"");
                contents = contents.Replace("<METHOD_GETPROCADDRESS>", "GLX.glXGetProcAddress");
            }
            if (os == SupportedOperatingSystem.Windows)
            {
                contents = contents.Replace("<LIB_OPENGL>", "opengl32.dll");
                contents = contents.Replace("<LIB_GLFW>", "glfw3.dll");
                contents = contents.Replace("<METHOD_GETPROCADDRESS>", "WGL.wglGetProcAddress");
            }

            File.WriteAllText(dest, contents);
        }

        static void DisplayHelp()
        {
            Console.WriteLine("Usage: generator <srcdir> <destdir> [options]");
            Console.WriteLine();
            Console.WriteLine("ABOUT");
            Console.Write("This cli tool was designed to easily update the OpenGL classes for use on different operating systems.");
            Console.Write("The <srcdir> directory should be the 'src' dir where are the GL* classes are located. In this repository, it is the actual 'src' dir.");
            Console.Write("The <destdir> directory is the directory where you want the tool to generate its output.");
            Console.Write("\n");
            Console.WriteLine();
            Console.WriteLine("OPTIONS");
            Console.WriteLine("-d    Delete the <destdir> directory if it exists already");
        }

        static string GetFileName(string path)
        {
            var result = path;
            result = result.Replace("\\", "/");
            result = result.Substring(result.LastIndexOf("/") + 1);

            return result;
        }
        static bool RequestsHelp(string[] args)
        {
            return args.Length == 1 && (args[0] == "-h" || args[0] == "--help");
        }
    }
}
