#include<stdio.h>
/*a=97,A=65*/
int main()
{
    char a[10];
    int i;
    scanf("%9s",a);
    for(i=0;i<10;i++)
    {
        if(a[i]>=97) printf("%c",a[i]-32);
        else if(a[i]>=65) printf("%c",a[i]+32);
    }
}
