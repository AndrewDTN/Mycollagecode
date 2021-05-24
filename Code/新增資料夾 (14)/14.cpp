#include<stdio.h>

struct myData{
        int number;
        char name[10];
        float score;
    };

int main()
{
    int a=1;
    char b='b';
    myData data;
    data.name[0]='a';
    data.number=1;

    printf("%d",data.number);
}
