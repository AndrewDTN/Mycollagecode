#include<stdio.h>

int main(void)
{
    float b=0,c=0,d=0,e=0;
    int n,k;

    printf("請輸入項數:");
    scanf("%d",&n);
    if(n<=0) printf("不要亂打");
    else
    {
        while(n>0)
        {
            k=n%2;
            if(k==1)
            {
                d=(2*n-1);
                d=4/d;
                b=b+d;
            }
            else
            {
                e=(2*n-1);
                e=4/e;
                c=c+e;
            }
            n--;
        }
        printf("%f,%f,%f,%f,\nπ=%f",d,e,b,c,b-c);
    }
}

