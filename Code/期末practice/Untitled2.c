#include<stdio.h>

int main()
{
    int i;
    char a[100];
    scanf("%s",&a);
    for(i=20;i>-1;i--)
    {
        if (a[i]==32) printf(" ");
        else printf("%c",a[i]);
    }
    printf("\n");
    for(i=0;i<=20;i++)
    {
        if(a[i]>=97 && a[i]<=123) printf("%c",a[i]-32);
        else if(a[i]>=65 && a[i]<=91) printf("%c",a[i]+32);
        else printf("%c",a[i]);
    }
}
