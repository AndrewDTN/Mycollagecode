#include<stdio.h>
#include<stdlib.h>
#include<time.h>


struct Card{
        int color;
        int point;
        int isCheck;
    };

int main ()
{
    srand(time(NULL));
    Card cards[52];

    for(int i=0;i<4;i++)
    {
        for(int j=0;j<13;j++)
        {
            cards[i*13+j].color=i+1;
            cards[i*13+j].point=j+1;
            cards[i*13+j].isCheck=0;
        }
    }

    int total=52;
    for(int i=0;i<10;i++)
    {
        int j=(rand()%total)+1;
        int counter=0;
        int k;
        for(k=0;k<52;k++)
        {
            if(cards[k].isCheck == 0) counter++;
            if(counter==j)break;
        }
        cards[k].isCheck=1;
        total--;

        printf("%d %d %d\n", cards[k].color, cards[k].point, j);
    }

}
