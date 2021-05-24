#include<stdio.h>

int perfect(int x);
int main()
{
    int a;
    for(a=1;a<1001;a++)
    {
        perfect(a);
    }
}

int perfect (int x)
{
    int i,total=0;
    for (i=1;i<x;i++)
    {
        if (x%i==0)
        {
            total+=i;
            if (total==x)
            {
                for(i=1;i<x;i++)
                {
                    if (x%i==0)printf("[%d] ",i);
                }
                printf("%d is perfect number\n",x);
            }
        }
    }
}
