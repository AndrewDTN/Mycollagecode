
#include<stdio.h>
#include<stdlib.h>
#include<time.h>

int main(void)
{
    srand(time(NULL));
    int answer=rand()%100+1;
    int low=1,high=100;
    int guess;
    int i=1;

    printf("這是一個猜數字遊戲\n");

    {
    while(guess!=answer && i<10)
            {
                printf("%d到%d內請猜出正確答案: ",low,high);
                scanf("%d",&guess,&guess);
                if (guess > low && guess < high)
                    {
                        if(answer==guess) printf("恭喜你答對了\n");
                        else
                        {
                            printf("你猜錯了\n");
                            if(guess>answer) high=guess;
                            else low=guess;
                            i++;
                        }
                    }
                else printf("請不要亂打\n");
            }
        if(i<=5) printf("猜的次數:%d 心有靈犀\n",i);
        else printf("猜的次數:%d 再接再厲\n",i);
    }

}
