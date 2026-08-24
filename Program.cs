

// int x =10;

/* int x =10;
 * 
 */

/*
Comment: Ctrl + K, Ctrl + C
Uncomment: Ctrl + K, Ctrl + U
*/




//2 
using System;

int x = 10;
int y = 20;
Console.WriteLine(x + y);

/* runtime error خطأ بيظهر أثناء تشغيل البرنامج، وبيخلي البرنامج يفشل أو يتوقف.

مثال:int x = 10;
int y = 0;
Console.WriteLine(x / y);

Logical Error البرنامج يشتغل عادي ومفيش Error بيظهر، لكن النتيجة بتكون غلط بسبب خطأ في منطق البرنامج
int x = 10;
int y = 20;
int sum = x - y;
Console.WriteLine(sum);
*/








//3
string FullName = "Ahmed Ali";
int Age = 25;
double MonthlySalary = 10000.50;
bool IsStudent = true;

//Naming conventions make the code easier to read, understand, and maintain. They also make the code consistent and professional.





//4
class Person
{
    public string name;
}

Person person1 = new Person();
person1.name = "Ahmed";

Person person2 = person1;

person2.name = "Ali";

Console.WriteLine(person1.name);
Console.WriteLine(person2.name);











//5


using System;

int x = 15;
int y = 4;

Console.WriteLine("sum: " + (x + y));
Console.WriteLine("Difference: " + (x - y));
Console.WriteLine("Product: " + (x * y));
Console.WriteLine("Division: " + (x / y));
Console.WriteLine("Remainder: " + (x % y));




int a = 2, b = 7;
Console.WriteLine(a % b);//2









//6
int number = 12;

if (number > 10 && number % 2 == 0)
{
    Console.WriteLine("The number is greater than 10 and even.");
}
else
{
    Console.WriteLine("The number does not meet both conditions.");
}







//7

Console.Write("Enter a double number: ");
double number = double.Parse(Console.ReadLine());

int explicitNumber = (int)number;

Console.WriteLine("Double value: " + number);
Console.WriteLine("Int value: " + explicitNumber);

//Explicit casting is required because converting a double to an int may cause data loss. The decimal part is removed,
//so C# requires us to explicitly tell the compiler that we accept this loss of information.
