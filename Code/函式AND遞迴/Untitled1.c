#include<stdio.h>
char Atoa(char A);
int main(void)
{
   char A;
   printf("enter big word:");
   scanf("%c",&A);
   printf("%c %c",A,Atoa(A));
}
char Atoa(char A)
{
   char a;
   if(A>='A' && A<='Z')
   a=A+32;
   else
   a=A-32;
   return a;
}
