#include<stdio.h>

int main()
{
    int a,b,c;
    int ans;
    int ok=0;

    scanf("%d %d %d",&a,&b,&c);
    //AND
    if(a == 0 && b == 0) ans=0;
    else if(a == 0 && b != 0) ans=0;
    else if(a != 0 && b == 0) ans=0;
    else if(a != 0 && b != 0) ans=1;
    if(ans==c)
    {
        printf("AND\n");
        ok=1;
    }

    //OR
    if(a == 0 && b == 0) ans=0;
    else if(a == 0 && b != 0) ans=1;
    else if(a != 0 && b == 0) ans=1;
    else if(a != 0 && b != 0) ans=1;
    if(ans==c)
    {
        printf("OR\n");
        ok=1;
    }


    //XOR
    if(a == 0 && b == 0) ans=0;
    else if(a == 0 && b != 0) ans=1;
    else if(a != 0 && b == 0) ans=1;
    else if(a != 0 && b != 0) ans=0;
    if(ans==c)
    {
        printf("XOR\n");
        ok=1;
    }
    if(ok==0) printf("impossible\n");
}



