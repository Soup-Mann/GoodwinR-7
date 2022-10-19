//Reed Goodwin
//10-19-2022
//MiniCHallenge#7
//THis console project will reverse a number and a word

Console.Clear();
string uOne;
bool isConverted = true;
bool isNumber;

long validNum = 0;

string fullstop = "";

Console.WriteLine("Welcome to Reeds Reverse it challenge!");
Console.WriteLine("");



while (isConverted)
{

    while (fullstop != "no")
    {


        Console.WriteLine("Please enter your a number");
        uOne = Console.ReadLine();


        isNumber = Int64.TryParse(uOne, out validNum);
        Console.WriteLine("");

        Console.WriteLine("");
        Console.WriteLine("");
        if (isNumber == true)
        {
            Console.Clear();

            Console.WriteLine("Valid Entry");
            Console.WriteLine("");

            for (int i = 0; i < uOne.Length; i++)
            {
                Console.Write(uOne[i]);
            };
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("Reversed");
            Console.WriteLine("----------");


            string reversedString = String.Empty;
            for (int i = uOne.Length - 1; i > -1; i--)
            {
                reversedString += uOne[i];

            };

            Console.WriteLine(reversedString);
        }
        else
        {
            Console.WriteLine("Invalid entry, please try again");
        }

        Console.WriteLine("------------");

        Console.WriteLine("Please enter a word");
        string rvrsd = Console.ReadLine();
        Console.WriteLine("");
        for (int i = 0; i < rvrsd.Length; i++)
        {
            Console.Write(rvrsd[i]);
        };
        Console.WriteLine("");
        Console.WriteLine("----------");
        Console.WriteLine("Reversed");
        Console.WriteLine("----------");


        string reversedDeez = String.Empty;
        for (int i = rvrsd.Length - 1; i > -1; i--)
        {
            reversedDeez += rvrsd[i];

        };
        Console.WriteLine(reversedDeez);

        Console.WriteLine("");
        Console.WriteLine("Would You Like to play again?");

        fullstop = Console.ReadLine().ToLower();
    }
    isConverted = false;
}

