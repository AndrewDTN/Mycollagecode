#include<stdio.h>
#include<math.h>
int main(void)
{
    int a,b,n;
    float c;

    for(a=1;a<=500;a++)
    {
        for(b=1;b<=500;b++)
        {
            c=pow(a*a+b*b,0.5);
            if(c==(int)c && c<=500)
            {
                printf("%d ,%d ,%d\n",a,b,(int)c);
            }
        }
        n++;
    }
    printf("TOTAL:%d",n);
}
