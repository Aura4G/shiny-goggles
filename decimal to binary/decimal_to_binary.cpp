#include <iostream>
#include <string>
#include <ctype.h>
#include "a4gcnvnc.h"
using namespace std;

string dectobin(int decNum)
{
    string answer = "";
    int comparator = 128;
    for (int i = 0; i < 8; i++)
    {
        if (decNum >= comparator)
        {
            answer = answer + "1";
            decNum -= comparator;
        }
        else
        {
            answer = answer + "0";
        }
        comparator = comparator / 2;
    }
    return answer;
}

int main()
{
    bool running = true;
    while (running)
    {
        int decNum;
        cout << "Enter a base-10 integer: ";
        cin >> decNum;

        cout << to_string(decNum) + " = " + dectobin(decNum) + "\n";
        again(&running);
        cout << endl;
    }
    
    return 0;
}