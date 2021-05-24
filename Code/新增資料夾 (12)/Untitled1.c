#include<stdio.h>

void area(int *pointer);

int main()
{
    int length = 10;
    area(&length);

    printf("%d\n", length);
}

void area(int *pointer)
{
    int squre = (*pointer) * (*pointer);

    printf("%d\n", squre);

    *pointer = 20;
}
