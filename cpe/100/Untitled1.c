#include<stdio.h>

int main(){
    int fir,end;
    scanf("%d %d",&fir,&end);
    int i,j;
    int max=0;
    for(i=fir;i<=end;i++){
        j=i;
        int num=1;
        while(j!=1){
            if(j%2!=0){
                j=3*j+1;
                num++;
            }
            else{
                j=j/2;
                num++;
            }
        }
        if (num>max) max=num;
    }
    printf("%d %d %d\n",fir,end,max);
}

