#include<stdio.h>

int main(void)
{
    int number;
    scanf("%d",&number);
    int input[number];
    for(int i=0;i<number;i++)
    {
        scanf("%d",&input[i]);
    }

    for(int j=0;j<number;j++)
    {
        int a=input[j];
        while(1)
        {
            int ans=0;
            for(int i=0;i<10;i++)
            {
                int temp = a%10;
                ans+=temp*temp;
                //printf("%d\n",temp);//

                if(a<10) break;
                a/=10;
            }
            //printf("%d\n",ans);
            a=ans;

            if(ans==1)
            {
                printf("%d is happy number\n",input[j]);
                break;
            }
            else if(ans==4)
            {
                printf("%d is unhappy number\n",input[j]);
                break;
            }
            else a=ans;
        }
    }
}
