# CODEKATA - An ultimate guide to interview success
The repository is created to solve the fundamental interview questions, focussing on data structures and algorithms.  
This file maintains the details of each program and the related source/other information.
* The repository currently supports two languages: C++ and C#  
* IDE: Visual Studio 2019 (.net version 8.0)  

## Problem Categories
The repository/project CodeKata (aka **CK**) is divided into different categories, as follows with respective readme file.


### CATEGORY1: Algorithm Fundamentals
This section includes all the basic fundamental algorithms and the varieties of implementations  
[View readme for details](readme-cat1.md)
  
  
  
### CATEGORY2: Problems
This section includes various problems from different online sources and real interview sessions  
[View readme for details](readme-cat2.md)  
  

    
### CATEGORY3: Algorithms: 24-part Lecture Series
This section includes all the problems discussed from the book: Robert Sedgewick / Kevin Wayne  
Book Url: [Algorithms - 4th Edition](https://algs4.cs.princeton.edu/home/)   
[View readme for details](readme-cat3.md)  


## Code Contribution

1. Create a new issue or pick existing one from project board  https://github.com/om-ganesh/codekata/projects/1
2. Update the readme file with the title, description, and reference (if any) for the problem. [Check sample here...](readme-cat1.md)
3. Create your problem branch from default branch i.e. [dev](https://github.com/om-ganesh/codekata/commits/dev) (include issue#, problem description, followed by name)  
For example: _ck-24-palindrome-subash_  
4. Use your favorite language and editor to code the problem  
5. Don't forget to provide link to your solution file in the problem description of readme file, created at step2 above.
6. Make a pull request to merge the code to **dev**
7. The PR must be reviewed by at least one contributor and then ready for merge  
8. During merge, use **Squash and Merge** option to merge your work to the **dev** branch.
9. Please follow following format to the commit message  

```
CK-[ISSUE #] Title of the Commit <=Subject line (50 character max)

# Description <= Message block (Optional, 72-character wrapped)
```
**FYI;** This template is already available in the repository, so just follow these steps to apply the commit template.  
- Go to the root path of the repository in your gitbash  
- Write the following command to configure your commit template  
_$git config commit.template ".github/.commit"_  
- Now, whenever you type **git commit**, it will open the template in your default git editor  
_$git commit_ 
- Just update the issue number, title, and description  and you are good with the template  