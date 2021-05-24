#include<stdio.h>

int main(){
    int times,day,party,i,j,k,l;
    int no[101];
    scanf("%d\n",&times);
    for(i=0;i<times;i++){
      scanf("%d\n",&day);
      scanf("%d\n",&party);
      for(k=0;k<party;k++) scanf("%d",&no[k]);
      int hartal = 0;
      for(j=1;j<=day;j++){
        if(j%7 == 6){
            j++;
            continue;
        }
        for(l=0;l<party;l++){
          if(j%no[l]==0){
            hartal++;
            break;
          }
        }
      }
      printf("%d\n",hartal);
    }
    return 0;
  }
