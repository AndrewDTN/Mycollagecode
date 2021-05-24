#include<stdio.h>

int main(void)
{
    int i=0;
    int score;
    float total=0;

    while(i<10)
    {
        scanf("%d", &score);
        total=total+score;
        i++;
    }
    printf("%f", total/i);
    }
