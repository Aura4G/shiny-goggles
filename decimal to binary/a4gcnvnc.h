//A collection of subroutines I've put into a header so I can easily call them in my programs. These functions get used alot in my work.
#include <iostream>
#include <string>
using namespace std;

//procedure to either restart or quit the program
void again(bool *toRun)
{
    bool rpsValid = false;
    string response = "";
    while (!rpsValid)
    {
        cout << "Again? 1 for yes, 0 for no: ";
        cin >> response;
        if (response == "0")
        {
            rpsValid = true;
            *toRun = false;
        }
        else if (response == "1")
        {
            rpsValid = true;
        }
        else
        {
            cout << "Invalid input entered. Please try again.\n";
        }
    }
}