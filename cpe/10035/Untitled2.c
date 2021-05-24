#include<stdio.h>
int main(){
    int i,j,count=0;
    while(1){
        count=0;
        scanf("%d %d",&i,&j);
        if(i==0&&j==0) break;
        while(i!=0 || j!=0){
            if((i%10)+(j%10)>=10){
                count++;
                i=i+10;
            }
            i=i/10;
            j=j/10;
        }
        if(count==0) printf("No carry operation.\n");
        else printf("%d carry operation.\n",count);
    }

}
