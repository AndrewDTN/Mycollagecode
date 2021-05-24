#include<stdio.h>
#include<stdlib.h>
#include<time.h>


struct Card{
        int color;
        int point;
        int isCheck;
    };

int main()
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

    for(int i=0;i<52;i++)
    {
        int j=rand()%52;
        Card temp=cards[i];
        cards[i]=cards[j];
        cards[j]=temp;
    }
    for(int i=0;i<5;i++)
    {
        printf("%d %d\n",cards[i].color,cards[i].point);
    }
}
