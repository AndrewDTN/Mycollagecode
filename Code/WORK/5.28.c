#include<stdio.h>

char change(char x);
int main(void)
{
    char ans;
    printf("請輸入一個英文字母:");
    scanf("%c",&ans);
    printf("%c %c",ans,change(ans));
}
char change(char x)
{
    char A;
    if (x>='a' && x<='z') A=x-32;
    else if (x>='A'&&x<='Z') A=x+32;
    else A=A;
    return A;
}

