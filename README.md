# Nebula Assessment - Amira Nazri

Database Challenges

Question 1
- Move “Cellphone Package”, “Cellphone Contract Start” and “Cellphone Contract End” over to the Event Detail table so that all information pertinent to the employee’s cellphone number is grouped under one table.
- Remove vendor from the Employee table as you can access the data via the Event Detail entity.

Question 2
SELECT movie_name, tickets_sold, genre, view_date FROM movies;
[INSERT SCREENSHOT]

Back-end Code Challenges

Question 1
Compile "question1.exe" by running mcs question1.cs.
Run the executable by running mono question1.exe

Question 2
- Each class has been made public and moved to its own file.
- The Eat() method is removed from the Horse and Sheep classes, and is called by creating a new Horse / Sheep object via the main.
- Because MakeNoise() returns a different value for each animal I have kept it in its own class as the Virtual type can be overridden with the inheriting class function with the same name.

Front-end Code Challenges

Question 1
1. The first div will be red, and the second will be orange.
2. [INSERT SCREENSHOT]
3. [INSERT SCREENSHOT]

Question 2
1) The function will parse correctly because it takes in an argument. Regardless of that argument, the function will read through its contents until it finds a value for x, which it would have found from the function call. The var x will likely reflect as a warning, but not as an error.
2) Declare the variable x at the beginning of the function, or remove it completely as it currently does nothing for the function without being given a value. Alternatively, if the var x serves a purpose, it can be assigned a value within the function to begin with.