#include<stdio.h>

int main()
{
    int a[6]={98,61,71,37,5,64,37};
    int i,j;
    int temp;
    for(j=0;j<=5;j++)
    {
        for(i=0;i<6;i++)
        {
            if(a[i]>a[i+1])
            {
                temp=a[i];
                a[i]=a[i+1];
                a[i+1]=temp;
            }
            printf("%d ",a[i]);
        }
        printf("\n");
    }

}
