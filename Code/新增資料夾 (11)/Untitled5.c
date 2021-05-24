#include<stdio.h>

int main()
{
    int i;
    int k;
    char string[100000];
    int data[100000];

    scanf("%d", &k);
    scanf("%s", string);
    for(i=0;i<10000;i++)
    {
        if(string[i]=='\0') break;
        if(string[i]>=65 && string[i]<=90) data[i]=1;
        else if(string[i]>=97 && string[i]<=122) data[i]=0;

        printf("%d", data[i]);
    }
}
