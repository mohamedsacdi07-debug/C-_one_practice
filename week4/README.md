# discous chapter 4

Chapter 4: Loops, Files, and Random Numbers

# 1. while Loop
Repeats statements as long as the condition is true.
It is a Pretest Loop (checks condition first).
# 2. Increment and Decrement Operators
++ Increases value by 1.
-- Decreases value by 1.
Prefix vs Postfix
Prefix: ++count – Changes value first.
Postfix: count++ – Uses old value first.
# 3. for Loop
Used when you know how many times a loop should repeat.
Has three parts:
Initialization
Condition (Test)
Update
# 4. do-while Loop
Executes statements at least once.
It is a Posttest Loop (checks condition after execution).
# 5. Using Files for Data Storage
Files are used to save data for later use.
Three steps:
Open the file.
Process the file (Read or Write).
Close the file.
Two types of files:
Text File: Stores data as text.
Binary File: Stores data in binary format.
Important Classes:
StreamWriter – Writes data to a file.
StreamReader – Reads data from a file.
Important Methods:
 # 6. OpenFileDialog and SaveFileDialog
OpenFileDialog – Allows users to select and open a file.
SaveFileDialog – Allows users to choose where to save a file.
ShowDialog() – Displays the dialog box.
DialogResult.OK – User clicks OK.
DialogResult.Cancel – User clicks Cancel.
FileName – Gets the selected file path.
InitialDirectory – Sets the starting folder.
# 7. Random Numbers
The Random class generates random numbers.
Next() – Generates a random integer.
NextDouble() – Generates a decimal number between 0.0 and 1.0.
# 8. Load Event
Executes when the form is loaded.
Used to initialize the application.
Double-click the form in Designer to create the Load event.