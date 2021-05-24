#include<stdio.h>

int main()
{
    int a,b,c;
    int ans;
    int ok=0;

    scanf("%d %d %d",&a,&b,&c);

    if(a>1) a=1;
    if(b>1) b=1;
    //AND
    ans = a & b;
    if(ans==c)
    {
        printf("ANS\n");
        ok=1;
    }
    //OR
    ans = a | b;
    if(ans==c)
    {
        printf("OR\n");
        ok=1;
    }

    //XOR
    ans = a ^ b;
    if(ans==c)
    {
        printf("XOR\n");
        ok=1;
    }

    if(ok==0) printf("impossible\n");
}
