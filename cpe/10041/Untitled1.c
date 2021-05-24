#include<stdio.h>

int main(){
    int row,i,fir,j,count,tem,home,ans;
    int num[500];
    scanf("%d",&row);
    for(i=0;i<row;i++){
        scanf("%d",&fir);
        for(j=0;j<fir;j++){
            scanf("%d",&num[j]);
        }
        for(j=0;j<fir;j++){
            for(count=1;count<fir;count++){
                if(num[count-1]>num[count]){
                    tem=num[count];
                    num[count]=num[count-1];
                    num[count-1]=tem;
                }
            }
        }
        home=num[fir/2];
        ans=0;
        for(j=0;j<fir;j++){
            ans=ans+abs(num[j]-home);
        }
        printf("%d\n",ans);
    }
}
/*int main(){
 int i,j,k,datas,rowNum,tmp,ans,home;
 int rows[500];//資料存放

 //取得輸入資料
 scanf("%d",&datas);
 for(i=0;i<datas;i++){
  scanf("%d",&rowNum);

  for(j=0;j<rowNum;j++)
   scanf("%d",&rows[j]);

  //排序
  for(j=0;j<rowNum;j++){
   for(k=1;k<rowNum;k++){
    if(rows[k]<rows[k-1]){
     tmp=rows[k];
     rows[k]=rows[k-1];
     rows[k-1]=tmp;
    }
   }
  }

  //輸出答案
  home=rows[rowNum/2];
  ans=0;
  for(j=0;j<rowNum;j++){
   ans=ans+abs(rows[j]-home);
  }
  printf("%d\n",ans);

 }
}*/
