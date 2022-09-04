// See https://aka.ms/new-console-template for more information

//IDE = VISUAL STUDIO CODE.
//The Basic or C# Traditional Syntax is being added by Visual Studio when I create the Console App 
//Including Prblic or Private to the function Won'tt make the Program Run
//I should have used Visual Studio which is a bit easier but I already had vscode installed on my system so i decide to do it with vsCode


 void leapYear(int date){ //Function that calculates Next 20 leapYears, You just have to input the date 
int count = 0;
Console.WriteLine($"First 20 Leap Years From {date}  ");

while(count < 20)  //Use count to record how many times the leap year has been printed 
{

if(DateTime.IsLeapYear(date)) //Check if the Date argument is a leap Year
{
    Console.WriteLine($"{date} is a leap year"); 
    date = date + 4; //if its a Leap year increment by 4 and check again
    count =  count + 1; //increment the count
} 

else 
{
    date = date + 1; //if its not a leap Year increment the date by 1 and test again
    }

}

}
leapYear(1998);
