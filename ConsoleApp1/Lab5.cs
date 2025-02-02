﻿using System;
public static class Lab5
{
    public static void Main()
    {
        // declare variables
        int inpMark;
        string lastName;
        char grade = ' ';

        Console.Clear();
        // enter the student's last name
        Console.Write("Enter the last name of the student => ");
        lastName = Console.ReadLine();
        // enter (and validate) the mark
        do
        {
            Console.Write("Enter a mark between 0 and 100 => ");
            inpMark = Convert.ToInt32(Console.ReadLine());
        } while (inpMark < 0 || inpMark > 100);

        // Use the method to convert the mark into a letter grade
        grade = MarkToGrade(inpMark);

        // print out the results
        Console.WriteLine("{0}'s mark of {1} converts to a {2}", lastName,
		 inpMark, grade);
    }

    // Method: MarkToGrade
    // Parameter
    //      mark: call by value parameter to be converted to a letter grade
    // Returns: the corresponding letter grade
    public static char MarkToGrade(int mark)
    {
        char letterValue;

        // multi-alternative If statement to determine letter grade
        if(mark > 0 && mark < 50)
            letterValue = 'F';
        else if(mark >= 50 && mark < 60)
            letterValue = 'D';
        else if(mark >= 60 && mark < 75)
            letterValue = 'C';
        else if(mark >= 75 && mark < 85)
            letterValue = 'B';
        else if(mark >= 85 && mark <= 100)
            letterValue = 'A';
        else
        {
            Console.WriteLine("***Error - invalid mark");
            letterValue = 'X';
        }

        //return the letter grade back to Main
        return letterValue;
    }
}