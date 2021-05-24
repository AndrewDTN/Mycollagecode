#include<stdio.h>

int integerPower(int x,int y);
int main()
{
    int a;
    a=integerPower(5,3);
    printf("%d\n",a);
}

int integerPower(int x,int y)
{
    if(y==1) return x;
    else if (y==0) return 1;
    else return x*integerPower(x,y-1);
}
