#include<stdio.h>

int main()
{
    int a,b,n;
    printf("�п�J��ӼƦr:");
    scanf("%d %d",&a,&b);
    while(b!=0)
    {
        n=a%b;
        a=b;
        b=n;
    }
    printf("%d %d",a,a*b);
}
