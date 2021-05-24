#include<stdio.h>
#include<math.h>

int prime(int x);
int main()
{
    int a;
    for(a=2;a<10001;a++) prime(a);
}

int prime(int x)
{
    int i,k=0;
    for(i=2;i<pow(x,0.5);i++)
    {
        if(x%i==0) k=1;
    }
    if(k==0) printf("%dis prime\n",x);
    else printf("%dis not prime\n",x);
}
