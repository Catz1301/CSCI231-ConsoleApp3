using System;
using System.Numerics;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args) {
			/*
			 * 1. Write a C# program to print the sum of two numbers.
Test Data:
75 + 35
Expected Output :
110
========================================================================
2. Write a C# program to print the result of the following operations.
Test Data:
a. -5 + 8 * 6
b. (55+9) % 9
c. 20 + -3*5 / 8
d. 5 + 15 / 3 * 2 - 8 % 3
Expected Output :
43
1
?
?
=========================================================================
3. Write a C# program to print a face.
Expected Output
 +"""""+                                                
[| o o |]                                               
 |  ^  |                                                
 | '-' |                                                
 +-----+
=========================================================================
4. Write a C# program to print the area and perimeter of a circle. Go to the editor
Hint: You have to use C#'s Math.PI feature
Test Data:
Radius = 7 
Expected Output
Perimeter is = 47.12388980384689
Area is = 176.71458676442586
=========================================================================
5. Write a C# program that takes three numbers as input to calculate and print the average of the numbers

=========================================================================

6. Finding Diameter, circumference and Area. Input radius.

=========================================================================

7. Compare two integer to see which is the biggest
*/

			{
				Console.WriteLine("Part 1");
				Console.WriteLine();
				/*bool num1Set = false, num2Set = false;
				int num1 = 0, num2 = 0;
				while (!num1Set && !num2Set) {
					Console.Write("Enter 1st number: ");
					num1Set = int.TryParse(Console.ReadLine(), out num1);

					Console.Write("Enter 2st number: ");
					num2Set = int.TryParse(Console.ReadLine(), out num2);
				}*/

				Console.WriteLine(75 + 35);
				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
				
			} // Part 1

			{
				Console.WriteLine("Part 2");
				Console.WriteLine();
				Console.WriteLine(-5 + 8 * 6);
				Console.WriteLine((55 + 9) % 9);
				Console.WriteLine(20 + -3 * 5 / 8);
				Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 2

			{
				Console.WriteLine("Part 3");
				Console.WriteLine();
				
				Console.WriteLine(" +\"\"\"\"\"+");
				Console.WriteLine("[| o o |]");
				Console.WriteLine(" |  ^  |");
				Console.WriteLine(" | \'-\' |");
				Console.WriteLine(" +-----+");
				

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 3

			{
				Console.WriteLine("Part 4");
				Console.WriteLine();
				int r = 7; // circleRadius
				// Circle Perimeter
				Console.Write("Perimeter is = ");
				Console.WriteLine(2*Math.PI*r);
				Console.Write("Area is = ");
				Console.WriteLine(Math.PI * (r*r));

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 4

			{
				Console.WriteLine("Part 5");
				Console.WriteLine();
				Console.Write("Input first number: ");
				double num1 = double.Parse(Console.ReadLine());
				Console.Write("Input second number: ");
				double num2 = double.Parse(Console.ReadLine());
				Console.Write("Input third number: ");
				double num3 = double.Parse(Console.ReadLine());
				Console.WriteLine((double) (num1 + num2 + num3) / 3);

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 5

			{
				Console.WriteLine("Part 6");
				Console.WriteLine();
				Console.Write("Input a radius: ");
				int r = int.Parse(Console.ReadLine()); // circleRadius

				Console.Write("Diameter is = ");
				Console.WriteLine(2*r);
				Console.Write("Perimeter is = ");
				Console.WriteLine(2 * Math.PI * r);
				Console.Write("Area is = ");
				Console.WriteLine(Math.PI * (r*r));

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 6

			{
				Console.WriteLine("Part 7");
				Console.WriteLine();
				Console.Write("Enter first number: ");
				int num1 = int.Parse(Console.ReadLine());
				Console.Write("Enter second number: ");
				int num2 = int.Parse(Console.ReadLine());
				Console.WriteLine("First number > second number = " + (num1 > num2).ToString());
				Console.WriteLine("First number < second number = " + (num1 < num2).ToString());
				if (num1 > num2)
					Console.WriteLine("num1 is bigger");
				else if (num1 < num2)
					Console.WriteLine("num2 is bigger");
				else
					Console.WriteLine("Both num1 and num2 are equal.");

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 7


			/*
			 *  1. Enter a number. find out if the number entered is odd or even. 

				2. Enter user id and password. if both are correct, display a successful message. Otherwise display "incorrect login" message

				3. Enter two numbers. 
				If both numbers are larger than 20, 
				 display a message "Both numbers are larger than 20
				If one of the number is larger than 20,
				 display a message "one number is larger than 20
				else
				 If both numbers are smaller than 20,

				4. Enter your grade(in number). Display your grade. Use following grade scale.
				A : if grade > 90
				B : if grade > 85
				C : if grade > 75
				D : if grade > 70
				else F

				5. Enter three numbers. find out the largest number.

 */
			{
				Console.WriteLine("Part 1 - Exercise 2");
				Console.WriteLine();
				int oddOrEvenNum = int.Parse(ask("Enter a number: "));
				if (oddOrEvenNum % 2 == 0)
					Console.WriteLine("Number is even!");
				else
					Console.WriteLine("Number is odd!");

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 1 - Exercise 2

			{
				Console.WriteLine("Part 2 - Exercise 2");
				Console.WriteLine();
				Console.WriteLine("Login Systems v1.9.8.2");
				Console.WriteLine("User ID: meowingCat");
				Console.WriteLine("Password: DeadSquirrel");
				Console.WriteLine();
				string userID = ask("Enter User ID: ");
				string passwd = ask("Enter Password: ");
				string setUserID = "meowingCat";
				string setPasswd = "DeadSquirrel";
				if (setUserID.Equals(userID) && setPasswd.Equals(passwd))
					Console.WriteLine("Login successful!");
				else
					Console.WriteLine("Incorrect login");

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 2 - Exercise 2

			{
				Console.WriteLine("Part 3 - Exercise 2");
				Console.WriteLine();
				int num1 = int.Parse(ask("Enter first number: "));
				int num2 = int.Parse(ask("Enter second number: "));
				if (num1 > 20 && num2 > 20)
					Console.WriteLine("Both numbers are larger than 20.");
				else if (num1 > 20 || num2 > 20)
					Console.WriteLine("One number is larger than 20.");
				else
					Console.WriteLine("Both numbers less than or equal to 20.");

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 3 - Exercise 2

			{
				Console.WriteLine("Part 4 - Exercise 2");
				Console.WriteLine();
				int grade = int.Parse(ask("Enter your grade number: "));
				char gradeLetter = 'F';
				if (grade > 90)
					gradeLetter = 'A';
				else if (grade > 85)
					gradeLetter = 'B';
				else if (grade > 75)
					gradeLetter = 'C';
				else if (grade > 70)
					gradeLetter = 'D';
				else
					gradeLetter = 'F';
				Console.WriteLine("Your grade letter is: " + gradeLetter);

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 4 - Exercise 2

			{
				Console.WriteLine("Part 5 - Exercise 2");
				Console.WriteLine();
				int[] nums = new int[3];
				for (int i = 0; i < nums.Length; i++) {
					nums[i] = int.Parse(ask("num" + (i+1) + ": "));
				}
				int largest = 0;
				
				for (int j = 0; j < nums.Length; j++) {
					if (nums[j] > largest)
						largest = nums[j];
				}
				Console.WriteLine("Largest number is {0:D}", largest);

				Console.WriteLine();
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			} // Part 5 - Exercise 2

			static string ask(string prompt) {
				//throw new NotImplementedException();
				Console.Write(prompt);
				string returnVal = Console.ReadLine();
				return returnVal;
			}
		}

		static void writeln(string str, object? obj) {
			Console.WriteLine(str, obj);
		}


		static void write(string data, object? obj) {
			Console.Write(data, obj);
		}

		static void writeln<T>(T str) {
			Console.WriteLine(str);
		}


		static void write<T>(T data) {

		}
	}
}
