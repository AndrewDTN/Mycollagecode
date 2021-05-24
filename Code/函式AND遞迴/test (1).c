#include<stdio.h>

int fibSequences(int n);

int main(void)
{
    int i;
    for(i=0;i<=30;i++)
    {
        int ans = fibSequences(i);
        printf("%d\n", ans);
    }
}

int fibSequences(int n)
{
    if(n <= 1) return n;
    else return fibSequences(n-1) + fibSequences(n-2);
}
