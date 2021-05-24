#include<stdio.h>

int main()
{
    int data[5]={9,36,81,22,6};
    int i;
    for(i=0;i<=5;i++)
    {
        if(data[i]==36) printf("The answer is %d",i+1);
    }
}
