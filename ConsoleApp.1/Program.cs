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

//int a = 10;
//int b = 20;
//int c = 30;
//int d = 40;
//if (a > b)
//{
//    if (a > c)
//    {
//        if (a > d)
//        {
//            Console.WriteLine("a is big");
//        }
//        else
//        {
//            Console.WriteLine("d is big ");
//        }
//    }
//    else
//    {
//        if (c > d)
//        {
//            Console.WriteLine("c is big");
//        }
//        else
//        {
//            Console.WriteLine("d is big");
//        }
//    }

//}
//else
//{
//    if (b > c)
//    {
//        if (b > d)
//        {
//            Console.WriteLine("b is big ");
//        }
//        else
//        {
//            Console.WriteLine("d is big ");
//        }
//    }
//    else
//    {
//        if (c > d)
//        {
//            Console.WriteLine("c is big ");
//        }
//        else
//        {
//            Console.WriteLine("d is big");
//        }
//    }
//}






//1. Check if a number is positive  
//Input: 5
//Output: Positive number

//Console.WriteLine("enter a number");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num >  0)
//{
//    Console.WriteLine("positive number");
//}else
//{
//    Console.WriteLine("not positive number");
//}


//2. Check if a number is negative  
//Input: -3
//Output: Negative number

//Console.WriteLine("enter a number");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num < 0)
//{
//    Console.WriteLine("negative number");
//}else
//{
//    Console.WriteLine("not negative number");
//}


//3. Check if a number is even  
//Input: 8
//Output: Even number  

//Console.WriteLine("enter a number");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num %2 == 0)
//{
//    Console.WriteLine("even number");
//}
//else
//{
//    Console.WriteLine("not even number");
//}



//4. Check if a number is odd  
//Input: 9
//Output: Odd number  

//Console.WriteLine("enter a number");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num % 3 == 0)
//{
//    Console.WriteLine("odd number");
//}
//else
//{
//    Console.WriteLine("not odd number");
//}


//5. Check if a number is zero  
//Input: 0
//Output: Number is Zero

//Console.WriteLine("enter a number");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num == 0)
//{
//    Console.WriteLine("number is Zero");
//}
//else
//{
//    Console.WriteLine("number is not Zero");
//}


//6. Check if a string is empty  
//Input: ""
//Output: String is empty  

//Console.WriteLine("enter a string");
//string name = (Console.ReadLine());
//if(name == "")
//{
//    Console.WriteLine("string is empty");
//}else
//{
//    Console.WriteLine("string is not empty");
//}


//7. Check if an entered password is correct  
//Input: "Admin123"
//Output: Access Granted  

//Console.WriteLine("Enter a password:");
//string password = Console.ReadLine();

//if (password == "Admin123")
//{
//    Console.WriteLine("Access Granted");
//}
//else
//{
//    Console.WriteLine("Access is not Granted");
//}



//8. Check if a student passed (minimum 40 marks)  
//Input: 35
//Output: Failed  

//Console.WriteLine("enter a marks");
//int number = Convert.ToInt32(Console.ReadLine());
//if(number > 40)
//{
//    Console.WriteLine("passed");
//}
//else
//{
//    Console.WriteLine("failed");
//}


//9. Check if an employee worked overtime (more than 60 hours)  
//Input: 45
//Output: Overtime not Done  

//Console.WriteLine("enter a overtime");
//int minutes = Convert.ToInt32(Console.ReadLine());
//if (minutes > 60)
//{
//    Console.WriteLine("overtime is done");
//}
//else
//{
//    Console.WriteLine("overtime is not done");
//}


//10.Check if a customer is eligible for a discount (amount greater than 500)  
//Input: 1500
//Output: Eligible for Discount  

//Console.WriteLine("enter a discount");
//int amount = Convert.ToInt32(Console.ReadLine());
//if (amount >  500)
//{
//    Console.WriteLine("eligible for discount");
//}
//else
//{
//    Console.WriteLine("eligible for not discount");
//}


//            part == 2....


//11. Check if a number is greater than 100  
//Input: 120
//Output: Number is greater than 100

//Console.WriteLine("enter your number");
//int number = Convert.ToInt32(Console.ReadLine());
//if(number > 100)
//{
//    Console.WriteLine("number is greater than 100");
//}
//else
//{
//    Console.WriteLine("number is not greater than 100");
//}


//12. Check if a number is less than 50  
//Input: 30
//Output: Number is less than 50  

//Console.WriteLine("enter your number");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number > 50)
//{
//    Console.WriteLine("number is less than 50");
//}
//else
//{
//    Console.WriteLine("grater than 50");
//}


//13. Check if a person is eligible to vote (age 18 or above)  
//Input: 20
//Output: Eligible to Vote  

//Console.WriteLine("enter your age");
//int age = Convert.ToInt32(Console.ReadLine());
//if (age >= 18)
//{
//    Console.WriteLine("eligible to vote");
//}
//else
//{
//    Console.WriteLine("not eligible to vote");
//}


//14. Check if a person is a minor (age below 18)  
//Input: 15
//Output: Minor  

//Console.WriteLine("enter your age");
//int age = Convert.ToInt32(Console.ReadLine());
//if (age < 18)
//{
//    Console.WriteLine("minor");
//}
//else
//{
//    Console.WriteLine("major");
//}


//15. Check if a number is a multiple of 7  
//Input: 21
//Output: Multiple of 7  

//Console.WriteLine("enter your multiple number");
//int multiple = Convert.ToInt32(Console.ReadLine());
//if (multiple % 7 == 0)
//{
//    Console.WriteLine("multiple of 7");
//}
//else
//{
//    Console.WriteLine("not multiple of 7");
//}


//16. Check if a username is correct  
//Input: "student"
//Output: Valid Username  

//Console.WriteLine("enter your correct username");
//string username = (Console.ReadLine());
//if (username == "student")
//{
//    Console.WriteLine("valid username");
//}
//else
//{
//    Console.WriteLine("in valid username");
//}


//17. Check if a temperature is above 37°C  
//Input: 39
//Output: High Temperature  

//Console.WriteLine("enter your temperature");
//int temperature = Convert.ToInt32(Console.ReadLine());
//if (temperature > 37)
//{
//    Console.WriteLine("high temperature");
//}
//else
//{
//    Console.WriteLine("normal temperature");
//}


//18. Check if a shopping cart has at least one item  
//Input: 3
//Output: Cart is not Empty

//Console.WriteLine("enter a last one item");
//int items = Convert.ToInt32(Console.ReadLine());

//if (items > 0)
//{
//    Console.WriteLine("Cart is not Empty");
//}
//else
//{
//    Console.WriteLine("Cart is Empty");
//}


//19. Check if a person's height is at least 150 cm  
//Input: 160
//Output: Eligible  

//Console.WriteLine("Enter your height asted cm");
//int height = Convert.ToInt32(Console.ReadLine());

//if (height >= 150)
//{
//    Console.WriteLine("Eligible");
//}
//else
//{
//    Console.WriteLine("Not Eligible");
//}


//20.Check if a number is a single-digit number 
//Input: 7
//Output: Single - digit number

//Console.WriteLine("Enter a number:");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number >= 0 && number <= 9)
//{
//    Console.WriteLine("Single-digit number");
//}
//else
//{
//    Console.WriteLine("Not a single-digit number");
//}
