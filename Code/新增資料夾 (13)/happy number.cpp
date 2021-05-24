#include<stdio.h>//*********//

int main()
{
    char data[15]="123";

    char input[15]="123";
    for(int j=0;j<30;j++)
    {
        int ans=0;
        for(int i=0;i<15;i++)
        {
            if(input[i]=='\0') break;
            int temp=input[i]-48;
            ans+=temp*temp;
        }
        printf("%d\n",ans);

        sprintf(input,"%d",ans);
    }
}
