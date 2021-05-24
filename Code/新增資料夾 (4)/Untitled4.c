#include<stdio.h>

int main(void)
{
    int m=1;
    int n=1;
    float e=1;
    float ans;
    while(n<=10)
    {
        ans=1;
        m=1;
        while(m<=n)
        {
            ans=ans*m;
            m++;
        }
        e=e+1/ans;
        n++;
    }
    printf("%f\n",e);
}
