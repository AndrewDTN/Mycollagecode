
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

    printf("�o�O�@�Ӳq�Ʀr�C��\n");

    {
    while(guess!=answer && i<10)
            {
                printf("%d��%d���вq�X���T����: ",low,high);
                scanf("%d",&guess,&guess);
                if (guess > low && guess < high)
                    {
                        if(answer==guess) printf("���ߧA����F\n");
                        else
                        {
                            printf("�A�q���F\n");
                            if(guess>answer) high=guess;
                            else low=guess;
                            i++;
                        }
                    }
                else printf("�Ф��n�å�\n");
            }
        if(i<=5) printf("�q������:%d �ߦ��F�R\n",i);
        else printf("�q������:%d �A���A�F\n",i);
    }

}
