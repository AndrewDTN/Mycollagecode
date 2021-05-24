#include<stdio.h>
#include<string.h>
#include<stdlib.h>

int main(){
    int dic[200][2]={0};
    char fir[1000];
    char sec[1000];
    while(1){
        scanf("%s",&fir);
        int len = strlen(fir);
        for(int i=0;i<len;i++){
            dic[fir[i]][0]=1;
        }
        scanf("%s",&sec);
        int len2 = strlen(sec);
        for(int k=0;k<len2;k++){
            if(dic[sec[k]][0]==1){
                dic[sec[k]][1]=1;
            }
        }
        for(int n=0;n<200;n++){
            if(dic[n][1]==1) printf("%c",n);
        }
        printf("\n");
        memset(fir,0,len);
        memset(sec,0,len2);
        memset(dic,0,sizeof(dic));
        //printf("%d %d",sizeof(dic),strlen(dic));
    }
}
