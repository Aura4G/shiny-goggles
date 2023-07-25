#include <iostream>
#include <string>
#include <algorithm>

#include "a4gmath.h"
#include "a4gcnvnc.h"

using namespace std;
#define forDown(x, y) for (int i = x; i >= y; i--)
//This program aims to takes a user input, gives its factorial and returns the number of 0s trailing at its end

int main()
{
    bool running = true;
    int x;
    while (running)
    {
        cout << "Enter a number: ";
        cin >> x;

        if (x > 12 || x < -12)
        {
            cout << "Sorry, the factorial of this number exceeds the capabilities of 32 bits." << endl;
            continue;
        }

        //uses my function in the a4gmath header to return the factorial of x
        x = factorial(x);

        int answer = 0;

        string strfX = to_string(x);
        forDown(strfX.length() - 1, 0)
        {
            if (strfX.substr(i, 1) != "0")
            {
                break;
            }
            else
            {
                answer++;
            }
        }

        cout << "Trailing zeroes: " + to_string(answer) << endl;
        again(&running);
        cout << endl;
    }

    return 0;
}