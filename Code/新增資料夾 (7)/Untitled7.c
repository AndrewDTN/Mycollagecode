#include<stdio.h>
int factoril(int number);
int main(void)
{
    int ans = factoril(3);
    printf("%d\n",ans);
}

int factoril(int number)
{
    int ans;

    if(number==1) return ans=1;
    else return ans= factoril(number-1)*number;
}
