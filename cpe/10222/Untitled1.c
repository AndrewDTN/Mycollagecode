#include<stdio.h>
#include<string.h>

int main(){
    char code[] = "`1234567890-=qwertyuiop[]\\asdfghjkl;'zxcvbnm,./";
    //printf("%c",code[26]);
    char in[100];
    gets(in);
    int i ;
    for(i=0;i<strlen(in);i++){
        if(in[i]>='A' && in[i]<='Z'){
            in[i]+=32;
        }
        int j;
        for(j=0;j<46;j++){
            //if(in[i]==' ') printf("%c",in[i]);
            if(in[i]==code[j]){
                in[i]=code[j-2];
            }
        }
    }
    printf("%s",in);
}
