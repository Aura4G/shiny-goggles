#include <string>

using namespace std;

class dog
{
    public:
    string name;
    int age;
    string battleCry;
    dog(string pName, int pAge, string pCry)
    {
        name = pName;
        age = pAge;
        battleCry = pCry;
    }

};