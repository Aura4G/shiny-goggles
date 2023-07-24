#include <iostream>
#include <string>
#include <cmath>
using namespace std;

/*These arrays are called to place the corresponding word in the answer. The first array stores integers
1-19 while the second stores multiples of 10 from 20-90. These are the unique lexemes found in worded
numbers*/
string possibleSVals[] = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
string possibleDVals[] = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

string IntToEng(int x)
{
    //This string variable is returned at the end of the program and is to be filled.
    string answer = "";
    //counter: it's value is used to access a specific word from the arrays
    int count = 0;

    //These bool vars will turn true when specific selections are made
    bool milCheck = false;
    bool thouCheck = false;

    /*answer starts with negative if less than 0. It then becomes positive to work with the assignments
    and comparisons ahead.*/
    if (x < 0)
    {
        answer = "negative ";
        x = abs(x);
    }
    //0 is an easy comparison to make that can be done upfront.
    else if (x == 0)
    {
        answer = "zero";
    }

    /*this variable stores an int value that is compared to the passed int. The passed value is also
    subtracted by this value if it is greater*/
    int comparator = 1000000000;
    //pointer used with the intention of saving on memory (I wanted to test pointer implementation..)
    int* coptr = &comparator;
    if (x >= *coptr)
    {
        while (x >= *coptr)
        {
            x -= *coptr;
            count++;
        }
        answer = answer + possibleSVals[count - 1] + " billion ";
        count = 0;
    }
    //comparator scales downward regardless of x magnitude. pointer points to the new value
    comparator = comparator / 10;
    if (x >= *coptr)
    {
        while (x >= *coptr)
        {
            x -= *coptr;
            count++;
        }
        answer = answer + possibleSVals[count - 1] + " hundred ";
        milCheck = true;
        count = 0;
    }
    comparator = comparator / 10;
    if (x >= *coptr * 2)
    {
        while (x >= *coptr * 2) //comparator multiplied by 2 to stop when x is less than 20 units.
        {
            x -= *coptr;
            count++;
        }
        answer = answer + possibleDVals[count - 1] + " ";
        milCheck = true;
        x -= *coptr;
        count = 0;
    }
    comparator = comparator / 10;
    if (x >= *coptr) //This allows for the latter 10 values of the first array to be accessed.
    {
        while (x >= *coptr)
        {
            x -= *coptr;
            count++;
        }
        answer = answer + possibleSVals[count - 1] + " ";
        milCheck = true;
        count = 0;
    }
    comparator = comparator / 10;
    if (milCheck) //bool values from function start being used to add a specific word to the answer
    {
        answer = answer + "million ";
    }
    if (x >= *coptr)
    {
        while (x >= *coptr)
        {
            x -= *coptr;
            count++; //count incremented every time x is reduced by the comparator
        }
        answer = answer + possibleSVals[count - 1] + " hundred "; //the location of address count-1 is used to bring in the correct word.
        thouCheck = true;
        count = 0;
    }
    comparator = comparator / 10;
    if (x >= *coptr * 2)
    {
        while (x >= *coptr * 2)
        {
            x -= *coptr;
            count++;
        }
        answer = answer + possibleDVals[count - 1] + " ";
        thouCheck = true;
        x -= *coptr;
        count = 0;
    }
    comparator = comparator / 10;
    if (x >= *coptr)
    {
        while (x >= *coptr)
        {
            x -= *coptr;
            count++;
        }
        answer = answer + possibleSVals[count - 1] + " ";
        thouCheck = true;
        count = 0;
    }
    comparator = comparator / 10;
    if (thouCheck)
    {
        answer = answer + "thousand ";
    }
    if (x >= *coptr)
    {
        while (x >= *coptr)
        {
            x -= *coptr;
            count++;
        }
        answer = answer + possibleSVals[count - 1] + " hundred ";
        count = 0;
    }
    comparator = comparator / 10;
    if (x >= *coptr * 2)
    {
        while (x >= *coptr * 2)
        {
            x -= *coptr;
            count++;
        }
        answer = answer + possibleDVals[count - 1] + " ";
        x -= *coptr;
        count = 0;
    }
    comparator = comparator / 10;
    if (x >= *coptr)
    {
        while (x >= *coptr)
        {
            x -= *coptr;
            count++;
        }
        answer = answer + possibleSVals[count - 1] + " ";
        count = 0;
    }
    return answer;
}

int main()
{
    //loops the program unless a certain input is made
    bool running = true;
    while (running)
    {
        //takes integer input and places it in the function
        int x;
        cout << "Enter an integer: ";
        cin >> x;
        cout << IntToEng(x) << endl;

        //provides the user an option if they'd like to do the program again.
        string response;
        cout << "Again? Enter anything for yes, or 0 for no: ";
        cin >> response;
        if (response == "0")
        {
            running = false;
        }
        else
        {
            cout << endl;
        }
    }
    return 0;
}