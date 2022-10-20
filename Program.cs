//Kenneth Fujimura
//Last accessed: 10-19-2022
//GitHub Challenge # 7 - Reverse It
//This program takes in a number input from the user and then reverses it and reports that back to the user.
//Peer reviewed by:

Console.Clear();

//Greet User
Console.WriteLine("Hello and welcome!\n");

//Explain program
Console.WriteLine("In this program, I'll be asking you to input a number or series of numbers. Then I will tell you what the reverse order of those numbers are.\n");

bool repeatProgram = true;
//While loop to repeat program
while (repeatProgram == true){
    //input directions
    Console.WriteLine("Please provide your input. It can be a number, a series of numbers, or really anything: ");

    //input string declaration and input
    string userInput = Console.ReadLine();
    
    //create array; put the user inputs into the array
    char[] stringArray = userInput.ToCharArray();  
    
    //create an output string variable to contain the reverse of the user input, set the string to being empty
    string reverseUserInput = String.Empty;  
    
    //iterate over the array backwards with a for loop; fill the output variable with the reverse of the initial input
    for (int i = stringArray.Length - 1; i >= 0; i--)  
    {  
        reverseUserInput += stringArray[i];  
    }  
    
    //Output results
    Console.WriteLine("You originally inputted: " + userInput);
    Console.WriteLine("The reverse of that is: " + reverseUserInput);
    
    //Check if user wants to repeat task
    Console.WriteLine("Do you want to try that again? Y/N: ");
    
    bool verifyRepeat = true;
    //while loop to check for repeating program
    while (verifyRepeat == true){
        var repeatInput = Console.ReadLine();
        repeatInput = repeatInput.ToLower();

        //Check to see if the input is valid; loop if not
        if (repeatInput == "y" || repeatInput == "yes"){
            verifyRepeat = false;
            continue;
        }else if (repeatInput == "n" || repeatInput == "no"){
            repeatProgram = false;
            verifyRepeat = false;
        }else{
            Console.WriteLine("I do not understand that input, please answer \"Y/N\"");
            verifyRepeat = true;
        }
    }
}
Console.WriteLine("Thanks, have a great day!");