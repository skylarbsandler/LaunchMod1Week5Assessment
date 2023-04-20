# Mod 1 Week 5 Assessment

## Questions (10 Points Possible)
1. What would happen if you try to use a variable that is not in scope?
In this situation, I would receive an error that the variable does not exist in the current context.

2. Describe the three As of a test:  
A - Arrange (declare the objects/variables needed to perform the test)
A - Act (call the method that we are trying to test)
A - Assertion (comparing what we expect from the successfull execution of the method to what actually happened)

3. What is the difference between `public` and `private` access modifiers?
With public modifiers, the code is accessible by all classes. With private, the code is only accessible within the same class.

4. A method should:  (**Select all that apply**) <br/>
X (A) Make changes to an object X  
X (B) Return some information about an object X 
(C) Make changes to an object and return information about the object.  
(D) None of the Above.  


5. How did you determine what to answer for the question above?
I chose A and B for Question 4 as methods should only do one thing (Single Responsibility Principle). A method should either make changes to an object (Command) or return some information about an object (Query). The answer is not C because a single, well written method should not both make changes to an object while also returning information about an object. It is best practice in this case to create two different methods to handle each task seperately. 

## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a User project with a single User class.  The class works, but it needs some additional effort to be great! One thing that is missing is tests; your job is to write the tests that will confirm the functionality of the class. Write one test for the constructor, and at least one test for each of the other 4 methods. As you write the tests, you might find some refactoring opportunities; update the user class with any refactors you deem necessary and add a comment describing why you made that refactor.  The only rule is that all the existing methods must still exist when you are finished!


## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
* DM a link to your forked repository to your instructors
