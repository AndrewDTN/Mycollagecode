#include<stdio.h>

int square(int y);

int main(void)
{
    int ans=square(10);
    printf("%d",ans);
}

int square(int y)
{
    int ans=y*y;
    return ans;
}
