#include <iostream>
#include <fstream>
#include <string>

//This program was made when learning c++. I decided to test the creation of headers, classes and csv files.
//includes a header file that I made, containing the dog class
#include "dog.h"

using namespace std;

int main()
{
    //keeps the program running unless a certain input is made
    bool running = true;
    //fstream object made to use functions from the fstream header.
    fstream fout;

    while (running)
    {
        string initResp;
        cout << "Welcome to doggy daycare!\n";
        cout << "Would you like to add a new dog to the daycare (1), or quit (2) ?\n";
        cin >> initResp;

        if (initResp == "1")
        {
            //creates a csv file to write to.
            fout.open("dogsInDC.csv", ios::out | ios::app);
            string pName;
            int pAge;
            string pCry;

            cout << "Enter the name, age and cry of the dog in question:\n";
            cin >> pName;
            cin >> pAge;
            cin >> pCry;

            dog newDog(pName, pAge, pCry);
            
            //writes inputs to csv file as an entry.
            fout << newDog.name << ", "
                 << newDog.age << ", "
                 << newDog.battleCry << "\n";
            fout.close();
        }
        else if (initResp == "2")
        {
            running = false;
        }
        else
        {
            cout << "Invalid input entered, please try again.\n";
        }

        cout << "\n";
    }

    
    
    return 0;
}