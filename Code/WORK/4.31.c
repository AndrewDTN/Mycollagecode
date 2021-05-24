#include<stdio.h>

int main(void)
{
    int a,b,c,d,e,f;

    for(a=1;a<=9;a+=2)
    {
        for(c=9;c>a;c-=2)
        {
            printf(" ");
        }
        for(b=0;b<a;b++)
        {
            printf("*");
        }
        printf("\n");
    }
    for(d=7;d>=1;d-=2)
    {
        for(f=7;f>=d;f-=2)
        {
            printf(" ");
        }
        for(e=1;e<=d;e+=1)
        {
            printf("*");
        }

        printf("\n");
    }
}
