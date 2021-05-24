#include<stdio.h>

int factorial(int number);
int factorial2(int number);

int main(void)
{
    int ans = factorial(3);
    int ans2 = factorial2(3);
    printf("%d %d\n",ans, ans2);
}

int factorial(int number)
{
    if(number == 1) return 1;
    else return factorial(number-1) * number;
}

int factorial2(int number)
{
    int i, ans=1;
    for(i=1;i<=number;i++) ans *= i;
    return ans;
}
