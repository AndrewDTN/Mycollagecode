#include<stdio.h>

int main(void)
{
    int m,h;
    float k=0,j=0,a=0,b=0;

    for(m=1;m<1000;m++)
    {
        h=m%2;
        if(h==1)
        {
            a=2*m-1;
            a=4/a;
            k=a+k;
        }
        else
        {
            b=2*m-1;
            b=4/b;
            j=b+j;
        }
        printf("¶µ¼Æ:%d £k=%.2f\n",m,k-j);
        if(k-j>3.135 && k-j<3.14159)break;
    }
}
