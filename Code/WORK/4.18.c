#include<stdio.h>

int main(void)
{
    int a,n,m;

    for(m=1;m<=5;m++)
    {
        printf("\n�п�J�Ʀr(1~30): ");
        scanf("%d",&a);
        if (a<=30 && a>=1)
        {
            for(n=0;n<a;n++)
            {
                printf("*");
            }
        }
        else printf("�Ф��n�å�");
    }
}
