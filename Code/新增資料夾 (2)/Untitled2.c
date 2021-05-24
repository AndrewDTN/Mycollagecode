#include<stdio.h>

int main(void)
{
    int score;

    printf("½Ð¿é¤J¦¨ÁZ: ");
    scanf("%d",  &score);

    if(score >= 90)
    {
        printf("Great\n");
    }

    else if(score >= 60)
    {
        printf("Passed\n");
    }
    else
    {
        printf("Not Passed");
    }
}

