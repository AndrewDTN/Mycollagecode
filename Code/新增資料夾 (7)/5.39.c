#include<stdio.h>
int gcd(int x,int y);
int main(void)
{
    int a,b;
    printf("請輸入兩個數字: ");
    scanf("%d %d",&a,&b);
    int ans=gcd(a,b);
    printf("最大公因數為:%d\n",ans);
}

int gcd(int x,int y)
{
    if (y==0) return x;
    else return gcd(y,x%y);
}
