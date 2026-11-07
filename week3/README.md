# discouse chapter 3

## 1. bool Variables and Flags
Definition:
A Boolean variable is a variable that stores only two possible values: true or false.
A flag is a variable that signals whether a particular condition exists in a program.
There are two values:
true indicates that the condition exists.
false indicates that the condition does not exist.
Example:
Explanation:
The variable isStudent stores true, so the first message appears.
Important: Boolean variables are useful for controlling program decisions.
# 2. Comparing Strings
Definition:
String comparison is the process of comparing two strings to determine whether they are equal or different.
C# provides relational operators and methods for comparing strings.
A. Using the == Operator
The == operator checks whether the two strings are equal.
B. Using the != Operator
The != operator checks whether two strings are not equal.
C. Using String.Compare()
The String.Compare() method compares two strings.
Example:
Important return values:
0: Both strings are equal.
A negative number: The first string comes before the second.
A positive number: The first string comes after the second.
# 3. Preventing Data Conversion Exceptions with TryParse()
Definition:
An exception is an error that occurs while a program is running.
The TryParse() method helps prevent exceptions caused by users entering invalid numeric data.
Common TryParse methods:
General syntax:
The out keyword is required. It specifies that the target variable receives the converted value.
Example using int.TryParse()
Explanation:
textBox1.Text gets the user's input.
int.TryParse() checks whether the input can be converted to an integer.
out age stores the converted value.
If conversion succeeds, the result is true.
If conversion fails, the result is false.
Example using double.TryParse()
This method is useful when the user enters decimal numbers.
# 4. Input Validation
Definition:
Input validation is the process of inspecting data entered into a program to make sure it is valid before it is used.
Input validation helps prevent incorrect or unreasonable data from being processed.
Important difference between TryParse and Input Validation
TryParse() checks whether the input can be converted into a number.
Input validation checks whether the entered value is within an acceptable range.
Example:
Explanation:
The program checks two things:
Is the input a valid integer?
Is the number greater than 0 and less than or equal to 168?
Another example using test scores:
Important example from the chapter:
If a user enters 999 hours, TryParse() accepts it as a valid number. However, it is not a reasonable number of working hours in one week.
Therefore, we need input validation in addition to TryParse.
# 5. Radio Buttons and Check Boxes
These are Windows Forms controls that allow users to select options.
A. RadioButton
Definition:
A RadioButton allows users to select only one choice from several possible choices.
When a user selects one RadioButton, the other RadioButtons in the same group are automatically deselected.
This is called mutually exclusive selection.
Example:
Imagine a student registration form with:
Male
Female
The user can select only one option.
Common RadioButton Properties
Example:
You do not need to use the == true expression.
These two statements are equivalent:
B. CheckBox
Definition:
A CheckBox allows users to select multiple options.
It is commonly used to provide options such as Yes/No or True/False.
Example:
Imagine a registration form with these options:
Java
C#
Python
The user can select more than one programming language.
Common CheckBox Properties