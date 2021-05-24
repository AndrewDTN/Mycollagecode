#include<stdio.h>
#include<ctype.h>

int main(void)
{
    int a=isdigit('2');
    printf("%s",isdigit('a')?"digital":"character");
}
