
//A door has a keypad entry. The combination to get in is 13579. Write a while loop 
//(not a do while loop) that asks the user to enter a key code. The loop will repeat as long as 
//the user enters the wrong code. After the user enters the correct code, the program will print 
//out a welcome message.



bool i = true;
int passcode = 13579;

while (i)
{
  int code = int.Parse(Console.ReadLine());

  if (code == passcode)
  {
    Console.WriteLine("Welcome!");
    i = false;
  }
  else
  {
    Console.WriteLine("Wrong code!");
  }
}
