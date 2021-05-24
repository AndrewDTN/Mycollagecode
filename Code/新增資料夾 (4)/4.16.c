#include<stdio.h>
#include<math.h>

int main(void)
{
    int i,j,k;

    for(i=1;i<=10;i++)
    {
        for(j=0;j<i;j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n\n----------------\n\n");

    for(i=10;i>=0;i--)
    {
        for(j=0;j<i;j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n\n----------------\n\n");

    for(i=10;i>=0;i--)
    {
        for(k=10;k>i;k--)
        {
            printf(" ");
        }
        for(j=0;j<i;j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n\n----------------\n\n");

    for(i=1;i<=10;i++)
    {
        for(k=10;k>i;k--)
        {
            printf(" ");
        }
        for(j=0;j<i;j++)
        {
            printf("*");
        }
        printf("\n");
    }
}


