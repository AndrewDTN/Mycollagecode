#include<stdio.h>
#include<string.h>

int main()
{
    int n,i,j,f;
    int max=0;
    char str[1000];
    char c;
    int count[127]={0};
    scanf("%d\n",&n);
    for(i=0;i<n;i++)
    {
        gets(str);
        for(j=0;j<strlen(str);j++)
        {
            c=str[j];
            if(c>='a'&&c<='z') c-=32;
            if(c>='A'&&c<='Z') count[c]++;
        }
    }
    for(c='A';c<='Z';c++)
    {
        if(count[c]>max) max=count[c];
    }
    for(f=max;f>0;f--)
    {
        for(c='A';c<='Z';c++)
        {
            if(count[c]==f) printf("%c %d\n",c,f);
        }
    }
}
