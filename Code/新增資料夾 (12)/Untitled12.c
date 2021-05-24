#include<stdio.h>

int main()
{
    int data = 10;
    int *pointer;

    pointer = &data;

    printf("%d\n0x%p",*pointer,pointer);
}
