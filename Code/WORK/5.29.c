#include<stdio.h>
int lcm(int t,int k);
int gcd(int x,int y);
int main(void)
{
    int a,b;
    printf("�п�J��ӼƦr: ");
    scanf("%d %d",&a,&b);
    int ans=lcm(a,b);
    printf("�̤p�����Ƭ�:%d",ans);
}

int gcd(int x,int y)
{
    if(x==0) return y;
    else return gcd(y%x,x);
}

int lcm(int t,int k)
{
    return (t*k)/gcd(t,k);
}
