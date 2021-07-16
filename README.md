# .NET Deep Dive: NuGet Package Manager
This is the repository for the LinkedIn Learning course .NET Deep Dive: NuGet Package Manager. The full course is available from [LinkedIn Learning][lil-course-url].

![.NET Deep Dive: NuGet Package Manager][lil-thumbnail-url] 

Most programming languages have an associated package management system that helps find and install code libraries and their dependencies. For the .NET developer, NuGet is the official package manager. In this course, longtime .NET programmer Walt Ritscher looks at the NuGet integration within Visual Studio and the Visual Studio command line. Walt shows you how to install, update, and remove packages from .NET projects, as well as how to search the public NuGet Gallery and create private repositories for your team. He also details the process of creating and publishing custom packages. If you’re a .NET programmer, understanding the Visual Studio package management system is vital knowledge, so join Walt as he takes a deep dive into the NuGet package manager.

## Instructions
This repository has branches for each of the videos in the course. You can use the branch pop up menu in github to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go to the branch you want to access.

## Branches
The branches are structured to correspond to the videos in the course. The naming convention is `CHAPTER#_MOVIE#`. As an example, the branch named `02_03` corresponds to the second chapter and the third video in that chapter. 
Some branches will have a beginning and an end state. These are marked with the letters `b` for "beginning" and `e` for "end". The `b` branch contains the code as it is at the beginning of the movie. The `e` branch contains the code as it is at the end of the movie. The `main` branch holds the final state of the code when in the course.

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"


### Instructor

Walt Ritscher 
                            
Senior Staff Author

                            

Check out my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/walt-ritscher).

[lil-course-url]: https://www.linkedin.com/learning/dot-net-deep-dive-nuget-package-manager
[lil-thumbnail-url]: https://cdn.lynda.com/course/2894045/2894045-1626195285840-16x9.jpg
