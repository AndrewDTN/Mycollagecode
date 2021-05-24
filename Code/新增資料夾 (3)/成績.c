#include<stdio.h>

int main(void)
{
    int i=0;
    int score=0;
    float total=0;

    while(score != -1)
    {
        printf("Enter a grade, -1 to end: ");
        scanf("%d",&score);
        if(score!=-1)
        {
          total=total+score;
          i++;
        }
    }
    if(i==0) printf("No grade were enter");
    else printf("%.2f", total/i);

}
