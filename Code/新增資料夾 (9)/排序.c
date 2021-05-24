#include<stdio.h>

int main()
{
    int i,temp,j;
    int data[10]={2,6,4,8,10,12,89,68,45,37};
    for(j=0;j<9;j++)
    {
        for(i=0;i<9;i++)
        {
            if(data[i]>data[i+1])
            {
                temp=data[i];
                data[i]=data[i+1];
                data[i+1]=temp;
            }
        }
        for(i=0;i<10;i++) printf("%d ",data[i]);
        printf("\n");
    }
    printf("middle number : %d",data[4]);
}
