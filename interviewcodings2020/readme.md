# The real problems asked during interview sessions

## FACEBOOK
### **Goat Latin Problem**  
Definition: [Leetcode](https://leetcode.com/problems/goat-latin/)  
Solution: [GoatLatin.cs](Facebook/GoatLatin.cs)  

### **Find if the given string is palindrome (ignoring the chars except alphanumeric)**  
Definition: Determine if given string is a palindrome, considering only alphanumeric characters and ignoring cases.  
Solution: [PalindromeAlphaCharacters.cs](Facebook/PalindromeAlphaCharacters.cs)   



## MICROSOFT
### **Insert digit to find maximum Number**
Issue: https://github.com/om-ganesh/codekata/issues/29  
Definition: [Knowsh](https://www.knowsh.com/Notes/250501/Maximum-Possible-Value-By-Inserting-5)  
Discussion: [InsertDigit.png](../problems/hint-getmaxinsertdigitbetweennumber.png.png)   
Solution: [InsertDigitToReturnMax.cs](Microsoft/InsertDigitToReturnMax.cs)  


### **Read the datafile to produce required output as explained in description**  
Definition: You will be supplied with two data files in CSV format .
The first file contains statistics about various dinosaurs. The second file contains additional data.  
Given the following formula,   
speed = ((STRIDE_LENGTH / LEG_LENGTH) - 1) * SQRT(LEG_LENGTH * g) Where g = 9.8 m/s^2 (gravitational constant)  

Write a program to read in the data files from disk, it must then print the names of only the bipedal dinosaurs from fastest to slowest.
Do not print any other information.
```
$ cat dataset1.csv
NAME,LEG_LENGTH,DIET
Hadrosaurus,1.4,herbivore
Struthiomimus,0.72,omnivore
Velociraptor,1.8,carnivore
Triceratops,0.47,herbivore
Euoplocephalus,2.6,herbivore
Stegosaurus,1.50,herbivore
Tyrannosaurus Rex,6.5,carnivore

$ cat dataset2.csv
NAME,STRIDE_LENGTH,STANCE
Euoplocephalus,1.97,quadrupedal
Stegosaurus,1.70,quadrupedal
Tyrannosaurus Rex,4.76,bipedal
Hadrosaurus,1.3,bipedal
Deinonychus,1.11,bipedal
Struthiomimus,1.24,bipedal
Velociraptorr,2.62,bipedal
```
Solution: [DinosaurCsv.cs](Microsoft/DinosaurCsv.cs)  

### **Find the integer pairs with count to match the max count**  
Definition: 
```
Given an integer array, find the number of times a particular digit should be repeated to make its count equal to the count of the integer which is occurring max times.
Input: [1,2,2,3,2,2,3]
Output: {1:3,3:2}
Explanation: Here digit 2 is repeated max times i.e. 4.
For other digit 1 so, we need to add 3 times to make equal to 4 so => <1,3>
For other digit 3, we need to add it 2 times to make equal to 4 so => <3,2>
```
Solution: TODO  

  


## AMAZON

### **Calculate the Five Star Seller**  
Definition: https://aonecode.com/amazon-online-assessment-five-star-sellers  
Solution: [FiveStarSeller.cs](Amazon/FiveStarSeller.cs) 

### **Calculate the Shopping Patterns using Trio product list**  
Definition: https://aonecode.com/amazon-online-assessment-shopping-patterns  
Solution: [ShoppingPatternTrio.cs](Amazon/ShoppingPatternTrio.cs) 