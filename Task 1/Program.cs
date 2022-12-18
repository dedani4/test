using static System.Console;

 WriteLine ("Is the first number the second number squared?");
 WriteLine ("Enter 2 numbers: ");
 int a = Convert.ToInt32(ReadLine());
 int b = Convert.ToInt32(ReadLine());

 if ( a == b*b ){
    WriteLine($"Number {a} is number {b} squared");
 }
 else 
 WriteLine ($"Number {a} is not squared number {b}");
