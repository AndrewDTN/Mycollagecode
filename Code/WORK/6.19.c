#include<stdio.h>
#include<time.h>
#include<stdlib.h>

int main()
{
    int i,a,b,k;
    int total[13]={0};
    srand(time(NULL));
    for(i=0;i<3600;i++)
    {
        a=rand()%6+1;
        b=rand()%6+1;
        ++total[a+b];
    }
    for(k=2;k<13;k++)
    {
        printf("%d %d\n",k,total[k]);
    }
}
