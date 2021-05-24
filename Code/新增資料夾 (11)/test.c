#include<stdio.h>

int main()
{
    int i,j;
    int N,R;

    scanf("%d %d",&N,&R);
    int number[R];
    for(i=0;i<R;i++) scanf("%d",&number[i]);

    int order[N];
    for (i=0;i<N;i++) order[i]=0;
    for (i=0;i<R;i++)
    {
        j=number[i];
        order[j-1]=1;
    }

    int ok=0;
    for (i=0;i<N;i++)
    {
        if(order[i]==0)
        {
            ok=1;
            printf("%d ",i+1);
        }
    }
    if(ok==0) printf("*\n");
}
