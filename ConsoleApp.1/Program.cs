/*int a = 20;
int b = 10;
int c = 40;
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("a is big");
    }
    else
    {
        Console.WriteLine("c is big ");
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine("b is big ");
    }
    else
    {
        Console.WriteLine("c is big ");
    }
}*/
/*
int a = 10;
int b = 20;
int c = 30;
int d = 40;
if (a > b)
{
    if (a > c)
    {
        if (a > d)
        {
            Console.WriteLine("a is big");
        }
        else
        {
            Console.WriteLine("d is big ");
        }
    }
    else
    {
        if (c > d)
        {
            Console.WriteLine("c is big");
        }
        else
        {
            Console.WriteLine("d is big");
        }
    }

}
else
{
    if (b > c)
    {
        if (b > d)
        {
            Console.WriteLine("b is big ");
        }
        else
        {
            Console.WriteLine("d is big ");
        }
    }
    else
    {
        if (c > d)
        {
            Console.WriteLine("c is big ");
        }
        else
        {
            Console.WriteLine("d is big");
        }
    }
}*/






//1. Check if a number is positive  
//Input: 5
//Output: Positive number

/*Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("positive number");
}
else
{
    Console.WriteLine("not positive number");
}*/


//2. Check if a number is negative  
//Input: -3
//Output: Negative number

/*Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("negative number");
}
else
{
    Console.WriteLine("not negative number");
}*/


//3. Check if a number is even  
//Input: 8
//Output: Even number  
/*
Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("even number");
}
else
{
    Console.WriteLine("not even number");
}*/



//4. Check if a number is odd  
//Input: 9
//Output: Odd number  

/*Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 3 == 0)
{
    Console.WriteLine("odd number");
}
else
{
    Console.WriteLine("not odd number");
}*/


//5. Check if a number is zero  
//Input: 0
//Output: Number is Zero

/*Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 0)
{
    Console.WriteLine("number is Zero");
}
else
{
    Console.WriteLine("number is not Zero");
}*/


//6. Check if a string is empty  
//Input: ""
//Output: String is empty  

/*Console.WriteLine("enter a string");
string name = (Console.ReadLine());
if (name == "")
{
    Console.WriteLine("string is empty");
}
else
{
    Console.WriteLine("string is not empty");
}*/


//7. Check if an entered password is correct  
//Input: "Admin123"
//Output: Access Granted  

/*Console.WriteLine("Enter a password:");
string password = Console.ReadLine();

if (password == "Admin123")
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Access is not Granted");
}*/



//8. Check if a student passed (minimum 40 marks)  
//Input: 35
//Output: Failed  

/*Console.WriteLine("enter a marks");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 40)
{
    Console.WriteLine("passed");
}
else
{
    Console.WriteLine("failed");
}*/


//9. Check if an employee worked overtime (more than 60 hours)  
//Input: 45
//Output: Overtime not Done  

/*Console.WriteLine("enter a overtime");
int minutes = Convert.ToInt32(Console.ReadLine());
if (minutes > 60)
{
    Console.WriteLine("overtime is done");
}
else
{
    Console.WriteLine("overtime is not done");
}*/


//10.Check if a customer is eligible for a discount (amount greater than 500)  
//Input: 1500
//Output: Eligible for Discount  

/*Console.WriteLine("enter a discount");
int amount = Convert.ToInt32(Console.ReadLine());
if (amount > 500)
{
    Console.WriteLine("eligible for discount");
}
else
{
    Console.WriteLine("eligible for not discount");
}*/


//            part == 2....


//11. Check if a number is greater than 100  
//Input: 120
//Output: Number is greater than 100

/*Console.WriteLine("enter your number");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100)
{
    Console.WriteLine("number is greater than 100");
}
else
{
    Console.WriteLine("number is not greater than 100");
}*/


//12. Check if a number is less than 50  
//Input: 30
//Output: Number is less than 50  

/*Console.WriteLine("enter your number");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 50)
{
    Console.WriteLine("number is less than 50");
}
else
{
    Console.WriteLine("grater than 50");
}*/


//13. Check if a person is eligible to vote (age 18 or above)  
//Input: 20
//Output: Eligible to Vote  

/*Console.WriteLine("enter your age");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("eligible to vote");
}
else
{
    Console.WriteLine("not eligible to vote");
}*/


//14. Check if a person is a minor (age below 18)  
//Input: 15
//Output: Minor  

/*Console.WriteLine("enter your age");
int age = Convert.ToInt32(Console.ReadLine());
if (age < 18)
{
    Console.WriteLine("minor");
}
else
{
    Console.WriteLine("major");
}*/


//15. Check if a number is a multiple of 7  
//Input: 21
//Output: Multiple of 7  

/*Console.WriteLine("enter your multiple number");
int multiple = Convert.ToInt32(Console.ReadLine());
if (multiple % 7 == 0)
{
    Console.WriteLine("multiple of 7");
}
else
{
    Console.WriteLine("not multiple of 7");
}*/


//16. Check if a username is correct  
//Input: "student"
//Output: Valid Username  

/*Console.WriteLine("enter your correct username");
string username = (Console.ReadLine());
if (username == "student")
{
    Console.WriteLine("valid username");
}
else
{
    Console.WriteLine("in valid username");
}*/


//17. Check if a temperature is above 37°C  
//Input: 39
//Output: High Temperature  

/*Console.WriteLine("enter your temperature");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature > 37)
{
    Console.WriteLine("high temperature");
}
else
{
    Console.WriteLine("normal temperature");
}*/


//18. Check if a shopping cart has at least one item  
//Input: 3
//Output: Cart is not Empty

/*Console.WriteLine("enter a last one item");
int items = Convert.ToInt32(Console.ReadLine());

if (items > 0)
{
    Console.WriteLine("Cart is not Empty");
}
else
{
    Console.WriteLine("Cart is Empty");
}*/


//19. Check if a person's height is at least 150 cm  
//Input: 160
//Output: Eligible  

/*Console.WriteLine("Enter your height asted cm");
int height = Convert.ToInt32(Console.ReadLine());

if (height >= 150)
{
    Console.WriteLine("Eligible");
}
else
{
    Console.WriteLine("Not Eligible");
}*/


//20.Check if a number is a single - digit number
//Input: 7
//Output: Single - digit number

/*Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 0 && number <= 9)
{
    Console.WriteLine("Single-digit number");
}
else
{
    Console.WriteLine("Not a single-digit number");
}*/

//swipe 

/*int a = 20;
int  b = 10;
int x = a;
a = b;
b= x;
Console.WriteLine(a);
Console.WriteLine(b);*/

//Nested If Assignments

//Write a C# program to check if a person is eligible to vote.
//A person is eligible to vote if their age is 18 or above and they have a valid voter ID (hasID = true). 
/*
Console.WriteLine("enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your voter ID status (true/false):");
bool hasID = Convert.ToBoolean(Console.ReadLine());

if (age >= 18)
{
    if (hasID)
    {
        Console.WriteLine("Eligible to vote");
    }
    else
    {
        Console.WriteLine("Not eligible to vote");
    }
}
else
{
    Console.WriteLine("Not eligible to vote");
}*/

//Write a C# program to verify login credentials.
//The user is granted access only if the username is "admin" and the password is "1234". 
/*
Console.WriteLine("enter your username:");
string username = Console.ReadLine();
Console.WriteLine("enter your password");
string password = Console.ReadLine();
if (username == "admin")
{
    if (password == "1234")
    {
        Console.WriteLine("Access granted");
    }
    else
    {
        Console.WriteLine("Access denied");
    }
}
else
{
    Console.WriteLine("Access denied");
}*/

//3.Write a C# program to check if a number is both positive and even. 
/*Console.WriteLine("enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number % 2 == 0)
{
    Console.WriteLine("The number is positive and even.");
}
else
{
    Console.WriteLine("The number is not positive and even.");
}*/

//4.Write a C# program to check if a student has passed and scored above 90 marks. 
/*Console.WriteLine("Enter your marks:");
int marks = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your pass status (true/false):");
bool hasPassed = Convert.ToBoolean(Console.ReadLine());
if (hasPassed)
{
    if (marks > 90)
    {
        Console.WriteLine("The student has passed and scored above 90 marks.");
    }
    else
    {
        Console.WriteLine("The student has passed but scored 90 marks or below.");
    }

}
else
{
    Console.WriteLine("The student has not passed.");
}*/

//5.Write a C# program to check if a person is eligible for a government job.
//The person must be a citizen (isCitizen = true) and at least 18 years old. 
/*Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your citizenship status (true/false):");
bool isCitizen = Convert.ToBoolean(Console.ReadLine());
if (isCitizen == true)
{
    if (age >= 18)
    {
        Console.WriteLine("The person is eligible for a government job.");
    }
    else
    {
        Console.WriteLine("The person is not eligible for a government job due to age.");
    }

}
else
{
    Console.WriteLine("The person is not eligible for a government job due to citizenship status.");
}*/

//6.Write a C# program to check if a number is divisible by both 3 and 5. 
/*Console.WriteLine("enter a number");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 3 == 0)
{
    if (number % 5 == 0)
    {
        Console.WriteLine("The number is divisible by both 3 and 5.");
    }
    else
    {
        Console.WriteLine("The number is divisible by 3 but not by 5.");
    }
}
else
{
    Console.WriteLine("The number is not divisible by 3.");
}*/

//7.Write a C# program to check if a user is an admin and has permission to delete records. 
/*Console.WriteLine("Enter your role (admin/user):");
string role = Console.ReadLine();
Console.WriteLine("Do you have permission to delete records? (true/false):");
bool hasPermission = Convert.ToBoolean(Console.ReadLine());

if (role == "admin")
{
    if (hasPermission)
    {
        Console.WriteLine("The user is an admin and has permission to delete records.");
    }
    else
    {
        Console.WriteLine("The user is an admin but does not have permission to delete records.");
    }
}
else
{
    Console.WriteLine("The user is not an admin.");
}*/

//8.Write a C# program to check if a user is registered and has a paid subscription. Access is granted only if both conditions are true. isRegistered = true, hasPaid = true
/*Console.WriteLine("Are you registered? (true/false):");
bool isRegistered = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Do you have a paid subscription? (true/false):");
bool hasPaid = Convert.ToBoolean(Console.ReadLine());
if (isRegistered == true)
{
    if (hasPaid == true)
    {
        Console.WriteLine(" Access is granted");
    }
    else
    {
        Console.WriteLine("You not paid for subscription");
    }
}
else
{
    Console.WriteLine("You register is not sexes");
}*/

//9.Write a C# program to find the largest number among four given numbers. 


/*Console.WriteLine("enter number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number c");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number d");
int d = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        if (a > d)
        {
            Console.WriteLine("a is bog");
        }
        else
        {
            Console.WriteLine("d is big");
        }
    }
    else
    {
        if (c > d)
        {
            Console.WriteLine("c is big ");
        }
        else
        {
            Console.WriteLine("d is big ");
        }
    }
}
else
{
    if (b>c)
    {
          if (b>d)
        {
            Console.WriteLine("b is big ");
        }
        else
        {
            Console.WriteLine("d is big ");
        }
    }
    else
    {
        if (c > d)
        {
            Console.WriteLine(" c is big");
        }
        else
        {
            Console.WriteLine("d is big ");
        }
    }
}*/


//.10.Write a C# program to check if a year is a leap year and also divisible by 400. 
/*Console.WriteLine("enter a year");
int year = Convert.ToInt32(Console.ReadLine());
if (year % 4 == 0)
{
       if (year % 100 == 0)
       {
           if (year % 400 == 0)
           {
               Console.WriteLine("leap year and divisible by 400");
           }
           else
           {
               Console.WriteLine("not leap year and not divisible by 400");
           }
       }
       else
       {
           Console.WriteLine("leap year and not divisible by 400");
       }
}
else
{
    Console.WriteLine("not leap year and not divisible by 400");
}*/

//11.A person can apply if they are 18 or older and have passed the learner’s test. 
/*Console.WriteLine("enter your age");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("have you passed the learner's test (true/false)");
bool hasPassedTest = Convert.ToBoolean(Console.ReadLine());

if (age >= 18)
{
    if (hasPassedTest == true)
    {
        Console.WriteLine("You can apply.");
    }
    else
    {
        Console.WriteLine("You cannot apply.");
    }
}
else
{
    Console.WriteLine("You cannot apply.");
}*/

//.12.Write a program that checks if all three sides of a triangle are equal.
/*Console.WriteLine("Enter the first side of the triangle:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second side of the triangle:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third side of the triangle:");
int c = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    if (a == c)
    {
        Console.WriteLine("All three sides are equal.");
    }
    else
    {
        Console.WriteLine("Not all three sides are equal.");
    }
}
else
{
    Console.WriteLine("Not all three sides are equal.");
}*/

//.13.A person qualifies if their percentage is 85 or more and they come from a rural area. 
/*Console.WriteLine("Enter your percentage:");
int percentage = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Are you from a rural area? (true/false):");
bool isFromRuralArea = Convert.ToBoolean(Console.ReadLine());
if (percentage >= 85)
{
    if (isFromRuralArea == true)
    {
        Console.WriteLine("You qualify.");
    }
    else
    {
        Console.WriteLine("You do not qualify.");
    }

}
else
{
    Console.WriteLine("You do not qualify.");
}*/

//14.Write a program that checks if a number is three digits and even. 
/*Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 )
{
    if (number % 2 == 0)
    {
        Console.WriteLine("The number is three digits and even.");
    }
    else
    {
        Console.WriteLine("The number is three digits but not even.");
    }
}
else
{
    Console.WriteLine("The number is not three digits.");
}*/




/*for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/

/*for (int i = 1; i <= 5; i++)
{
    for (int j = i; j >= 1; j--)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/

/*for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/

/*for (int i = 1; i <= 5; i++)
{
    for (int j = 5; j >= 1; j--)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/

/*for (int i = 1; i <= 4; i++)
{
    for (int j = i; j <= 3; j++)
    {
        Console.Write("*");
    }
    for (int k = i; k >= 1; k--)
    {
        Console.Write(k);
    }
    Console.WriteLine();
}*/

/*for (int i = 1; i <= 4; i++)
{
    for (int j = i; j <= 3; j++)
    {
        Console.Write("*");
    }
    for (int k = i; k >= 1; k--)
    {
        Console.Write(Convert.ToChar(64 + k));
    }
    Console.WriteLine();
}*/


/*int num = 1;
for (int i = 1; i <= 4; i++)
{
    for (int j = i; j <= 4 - 1; j++)
    {
        Console.Write("*");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write(num);
        num++;
    }
    Console.WriteLine();
}*/

/*for (int i = 1; i <= 4; i++)
{
    for (int j = i; j <= 4 - 1; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write(k);
    }
    for (int l = i - 1; l >= 1; l--)
    {
        Console.Write(l);
    }
    Console.WriteLine();
}*/

/*for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 5 - i; k++)
    {
        Console.Write(k);
    }
    for (int k = 4 - i; k >= 1; k--)
    {
        Console.Write(k);
    }
    Console.WriteLine();
}*/

/*for (int i = 5; i >= 1; i--)
{
    for (int j = i; j >= 1; j--)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/

/*int num = 1;
for (int i = num; i <= 4; i++)
{
    for (int j = i; j <= 4; j++)
    {
        Console.Write(num);
        num++;
    }
    Console.WriteLine();
}*/


for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= i - 1; j++)
    {
        Console.Write(" ");
    }
    Console.Write("*");

    for (int k = 1; k <= 5 - i; k++)
    {
        Console.Write(k);
    }
    for (int l = i; l <= 3; l++)
    {
        Console.Write(" ");
    }

    Console.WriteLine("*");
}
int num = 3;
for (int i = 1; i <= num; i++)
{
    for (int j = i; j <= num; j++)
    {
        Console.Write(" ");
    }
    Console.Write("*");
    for (int k = 1; k <= i; k++)
    {
        Console.Write(" ");
    }
    for (int l = 1; l <= i - 1; l++)
    {
        Console.Write(" ");
    }

    Console.WriteLine("*");
}




Console.WriteLine();