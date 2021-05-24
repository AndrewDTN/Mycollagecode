#include<stdio.h>

void stringReverse();

char a[10]={};

int main()
{
    stringReverse();
}

void stringReverse()
{
    int i;
    scanf("%s",&a);
    for(i=9;i>-1;i--)
    {
        printf("%c",a[i]);
    }
}
