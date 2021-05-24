#include<iostream>
using namespace std;

int main(void)
{
    int data[5] = {1,2,3,4,5};

    for(int i=0;i<5;i++)
    {
        cout << data[i] << " ";
    }
    cout << "\n";
    cout << "Hello World" << endl;

    int a,b;
    char c;
    cin >> a >> b >> c;
    cout << a << " " << b << " " << c;
}
