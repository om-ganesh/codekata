# CODEKATA - An ultimate guide to interview success
The repository is created to solve the fundamental interview questions, focussing on data structures and algorithms.  
This file maintains the details of each program and the related source/other information.
* The repository currently supports two languages: C++ and C#  
* IDE: Visual Studio 2019 (.net version 8.0)  

## Problem Categories
The repository/project CodeKata (CK) is divided into following categorical projects. You can find the respective readme file for each project, illustrating the addressed problem solutions.  

1. cppsolutions.vcxproj, csharpproject.csproj [Read more](csharpproject/readme.md)  
	Includes all the problem solutions in C# and C++ language  
2. dsaexposed.csproj  [Read more](dsaexposed/readme.md)  
	It implements the fundamental algorithms in C#
3. interviewcodings.csproj   
	These are list of real interview faced myself (Yr2016-2020)  
4. JohanRuleEngine.csproj  
	This the interview problem asked on one of my previous company, Jonah
5. oopfundamentals.csproj  
	This project includes the illustration of basic OOP related concepts
6. rsedgewickalgos.csproj  [Read more](rsedgewickalgos/readme.md)  
	This project includes the problems from famous Algorithm books from famous R. Sedgewick and K. Wayne (https://algs4.cs.princeton.edu/home/)



## Code Contribution

1. Create a new issue or pick existing one from project board  https://github.com/om-ganesh/codekata/projects/1
2. Update the readme file with the definition and reference (if any) for the problem. [Check sample here...](readme-cat1.md)
3. Create new problem branch from default branch i.e. [master](https://github.com/om-ganesh/codekata/commits/master) (include issue#, problem description, followed by name)  
For example: _ck-24-palindrome-subash_  
4. Use your preferred language and editor to code the problem  
5. Commit your code (Note: Recommended commit template is already available in the repo, as also explained below)  
6. Provide the link to your code in readme file, from step2 above.
7. Make a pull request against **master** branch
8. Perform **Squash and Merge** to merge your work to the **master** branch. (Note: 1 mandatory reviewer should approve your PR)  
9. Please follow following format to the commit message  


## Commit Message Template  
```
Title of the Commit <=Subject line (50 character max)

# Description <= Message block (Optional, 72-character wrapped)

Related To #[IssueNumber]  
```
**Easy steps to follow this template:**   
- Go to the root path of the repository in your gitbash  
- Write the following command to configure your commit template  
_$git config commit.template ".github/.commit"_  
- Now, whenever you type **git commit**, it will open the template in your default git editor  
_$git commit_ 
- Just update the issue number, title, and description  and you are good with the template  