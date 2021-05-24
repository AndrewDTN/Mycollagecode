#include<stdio.h>

int main(void)
{
    int season;

    printf("請輸入月份: ");
    scanf("%d", &season);

    if(season >= 3 && season <= 5)
    {
        printf("Spring");
    }
    else if(season >= 6 && season <= 8)
    {
        printf("Summer");
    }
    else if(season >= 9 && season <= 11)
    {
        printf("Fall");
    }
    else
    {
        printf("Winter");
    }
}
