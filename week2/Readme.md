# discouse chapter2
# Topics 

3.1 Reading Input with TextBox Controls

3.2 A First Look at Variables

3.3 Numeric Data Type and Variables

3.4 Performing Calculations

3.5 Inputting and Outputting Numeric Values

# 3.1 Reading Input with TextBox Control

TextBox control

a rectangular area

can accept keyboard input
from the user

located in the Common
Control group of the
Toolbox

double click to add it to the
form

default name is textBoxn

where n is 1, 2, 3, …

# Variable Names

A variable name identifies a variable

Always choose a meaningful name for variables

Basic naming conventions are:

the first character must be a letter (upper or
lowercase) or an underscore (_)

the name cannot contain spaces

do not use

keywords or reserved words

 # 1.create variable
 
 Creating variables means declaring spaces to store data that we will use in the program.

string studentname, department, semester, fulloff;
int studentid;

string stores text.
int stores whole numbers.
These variables hold the student's information.

#  2. Concatenation

Concatenation means joining two or more pieces of text or values together to create one complete string.

fulloff = studentname + "," + studentid + "," + department + "," + semester;

It combines the student information into one line of text.

#  3. Display

Display means showing the final result to the user.

lbloutput.Text = fulloff;

This sends the value of fulloff to the label called lbloutput, so the user can see the result on the form.