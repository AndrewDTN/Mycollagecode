#include<stdio.h>
#include<vector>
using namespace std;

int main()
{
    vector<int>v1;
    for(int i=0;i<5;i++)
    {
        v1.push_back(i);
    }
    printf("%d",v1.size());
}
