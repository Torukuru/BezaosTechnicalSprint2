// See https://aka.ms/new-console-template for more information


//IDE = VISUAL STUDIO CODE.
//The Basic or C# Traditional Syntax is being added by Visual Studio when I create the Console App 
//Including Prblic or Private to the Method Wont make the Program Run
//I should have used Visual Studio which is a bit easier but I already had vscode installed on my system so i decide to do it with vsCode


//Program starts
string TranslatePigLatin(string Sentence) 
{ 

    string[] WordsArray = Sentence.Split(' '); //Convert the string to an array
    string LatinSentence = ""; //Variable for Storing the PigLatin Sentence
 foreach(var Word in WordsArray) 
 { //Loop through each item in the array
    string tempholder = Word; //Convert the first item to a string
     
     if (tempholder.Length > 0) 
 {
    string tempfirst;
    tempfirst = tempholder.Substring(0,1); //store the first Character of the Word
    string PigLatin =tempholder.Remove(0,1);  //remove the first character of the string and store it in the variable
    PigLatin = PigLatin + tempfirst + "ay" + " "; //Concatenate the string Variables
    LatinSentence = LatinSentence + PigLatin;  
 }
 }

 Console.WriteLine(LatinSentence); 
 return LatinSentence;

}
TranslatePigLatin("The quick brown fox"); //First  Run Case
TranslatePigLatin("I Love Jesus Christ"); //Second  Run Case
TranslatePigLatin("I Love Jesus Christ     these       Much        ");  //Third Test Run Case






//Second Function for translating PigLatin to English
string TranslateEnglish(string Sentence) {
    string[] WordsArray = Sentence.Split(' '); //Convert to array.
    string EnglishSentence = ""; //empty string for displaying or returning the final answer
    foreach(var Word in WordsArray) //Loop through each Word in the array
    {
        string tempholder = Word; //A temporary holder for each Word
        if(tempholder.Length > 2) //if You have more than two Letters Do These, helps solve the problem of extra spaces
        {
        int LastPlaceholder = tempholder.Length -2;
        string TempWord = tempholder.Substring(0, LastPlaceholder);//Stores the temp holder value with out the last two letters
        int LastPlaceholderTwo = TempWord.Length - 1;
        string LastString = TempWord.Substring(0, LastPlaceholderTwo); //Stores the Value of tempword with out the last value
        string EnglishWord = TempWord[LastPlaceholderTwo] + LastString + " "; //Concatenate it
        EnglishSentence = EnglishSentence + EnglishWord;
    }
    }
    Console.WriteLine(EnglishSentence);
    return EnglishSentence;

}
TranslateEnglish("heTay uickqay rownbay oxfay");
TranslateEnglish("Iay oveLay hristCay");
TranslateEnglish("Iay oveLay       hristCay      heseTay      uchMay");