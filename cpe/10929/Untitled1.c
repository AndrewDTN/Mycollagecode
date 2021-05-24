#include<stdio.h>
#include<string.h>

int main(){
    char num[1001];
    while(scanf("%s",&num)!=EOF){
        int i;
        long int len=strlen(num);
        if(num[0]=='0') break;
        int a=0,b=0;
        for(i=0;i<len;i++){
            if(i%2==0){
                a=a+(num[i]-'0');/*他代表的是'數字'的ASCII*/
            }
            else{
                b=b+(num[i]-'0');
            }
        }
        if((a-b)%11==0){
            printf("%s is a multiple of 11.\n",num);
        }
        else{
            printf("%s is not a multiple of 11.\n",num);
        }
    }
}
