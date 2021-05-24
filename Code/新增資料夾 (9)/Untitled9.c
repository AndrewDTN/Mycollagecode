#include<stdio.h>

int main ()
{
    int i;
    char data[5]={'a','b','c','d','e'};
    char Data[]="abcde";

    for(i=0;i<5;i++) printf("%c\n",data[i]);
    printf("%s\n",Data);
}
