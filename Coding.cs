using System.Runtime;
using System.Runtime.CompilerServices;

void Login(string[,] LoginData)
{
    string[,] TempLoginData = LoginData;
    bool ValidLogin = false;

    Console.WriteLine("Enter your username:"); //Username entered.
    string UserGuess = Console.ReadLine();

    Console.WriteLine("Enter your Password:"); //Password entered.
    string PassGuess = Console.ReadLine();

    //Checking the details against login database.
    for (int i = 0 ; i < TempLoginData.GetLength(0) ; i++)
    {
        if ((UserGuess == TempLoginData[i, 0]) && (PassGuess == TempLoginData[i, 1]))
        {
            ValidLogin = true;
        }
    }

    if (ValidLogin == true)
    {
        Console.WriteLine("Access Granted."); //Login details match.
        Test(); //User is tested on their knowledge of C.S. GCSE.
    }
    else
    {
        Console.WriteLine("Access Denied, try again.");
        Login(TempLoginData); //Login details incorrect, user tries again.
    }
}

//Method to test the user on their knowledge of C.S. GCSE.
void Test()
{
    int score = 0;

    //List of questions and answers for the test.
    string[] Questions =
    [
        "What type of memory is volatile: RAM or ROM?",
        "Convert the binary number 1010 to decimal.",
        "What is the name for the smallest unit of computer data?",
        "Which logic gate outputs TRUE only when both inputs are TRUE?",
        "What does CPU stand for?"
    ];
    string[] Answers =
    [
        "RAM",
        "10",
        "bit",
        "AND",
        "Central Processing Unit"
    ];
    
    //Looping through the questions and checking the user's answers.
    for(int i = 0 ; i < Questions.GetLength(0) ; i++)
    {
        Console.WriteLine(Questions[i]);
        string UserAnswer = Console.ReadLine();

        if (UserAnswer == Answers[i])
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect.");
        }
    }
    //Final message displaying the user's score.
    Console.WriteLine($"Well done! Your score is: {score}.");
}

void StrArrayOutput(string[] Array)
{
    for(int i = 0 ; i < Array.Length ; i++)
    {
        Console.Write(Array[i]+ " ,");
    }
}


bool LinearSearch(string[] Array, string Target)
{
    bool Found = false;

    for(int i = 0 ; i < Array.Length ; i++)
    {
        if (Target == Array[i])
        {
            Found = true;
            break;
        }
    }

    return Found;
}


void BubbleSort(string[] Array)
{
    int Swaps = 0;
    int Index = 0;
    string TempData1 = "Data";
    bool sorted = false;

    while(sorted == false)
    {
        Swaps = 0;
        Index = 0;

        while (Index < Array.Length - 1)
        {
            //Swaps the position of two index values if the lower index value is larger than the second.
            if(Convert.ToUInt16(char.Parse(Array[Index].Substring(0,1))) > Convert.ToUInt16(char.Parse(Array[Index + 1].Substring(0,1))))
            {
                TempData1 = Array[Index + 1];
                Array[Index + 1] = Array[Index];
                Array[Index] = TempData1;

                Swaps++;
            }
            Index++;
        }
        
        //Resets the swaps each pass.
        if(Swaps == 0)
        {
            sorted = true;
        }
    }
    //Sorted array outputted to the user.
    StrArrayOutput(Array);
}

void BinarySearch(string[] Array, string Target)
{
    int Head = Array.Length - 1;
    int Tail = 0;
    int Mid = Array.Length / 2;
    int IndexFound = 0;

    while (Tail <= Head)
    {
        Mid = (Head + Tail) / 2;

        if (Target == Array[Mid])
        {
            IndexFound = Mid;
            Console.WriteLine($"The student is in the database at index: {IndexFound}.");
            return;
        }
        else if (string.CompareOrdinal(Target, Array[Mid]) > 0)
        {
            Tail = Mid + 1;
        }
        else
        {
            Head = Mid - 1;
        }
    }

    Console.WriteLine("The student is not in the database.");
}

//List of usernames and passwords for the login system.
//string[,] Accounts = {{"Jimmy102", "Tim102", "Will102"},
//                      {"Password123", "Login123", "Login345"}};

//Begins login and test for user.
//Login(Accounts);

string[] Students = {"Jimmy", "Fin", "Harry", "Cody", "Tom", "Ruben", "Aiaa", "Matt"};
string[] SortedStudents = {"Aiaa", "Cody", "Fin", "Harry", "Jimmy", "Matt", "Ruben", "Tom"};

Console.WriteLine("What student are you looking for?:"); //User enters target student.
string StudentRequest = Console.ReadLine();

/*//Outputs whether the student is present in the database.
bool InArray = LinearSearch(Students, StudentRequest);
Console.WriteLine($"{InArray}: The student is not in the database.");*/

//Outputs a sorted array for the user using a bubble sort method.
//BubbleSort(Students);

//Searches and outputs the position of an item in an array.
BinarySearch(SortedStudents, StudentRequest);