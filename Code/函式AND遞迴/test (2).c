#include<stdio.h>

int main()
{
    int ans = gcd(70,35);
    printf("%d\n", ans);
}

int gcd(int x, int y)
{
    if (y == 0) return x;
    else return gcd(y, x%y);
}


