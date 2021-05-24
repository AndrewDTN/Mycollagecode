#include<stdio.h>

int main()
{
    int a,i;
    int b=0;
    int c=0;
    printf("Please enter a number:");
    scanf("%d",&a);
    for(i=2;i<a;i++)
    {
        if(a%i==0) b++;
        else c++;
    }
    if(b>0) printf("NOT");
    else if(c>0) printf("YES");
}
