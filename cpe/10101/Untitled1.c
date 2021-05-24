#include <stdio.h>

void num(long long int n){
    if(n>=10000000){
        num(n/10000000);
        printf(" kuti");
        n=n%10000000;
    }
    if(n>=100000){
        num(n/100000);
        printf(" lakh");
        n=n%100000;
    }
    if(n>=1000){
        num(n/1000);
        printf(" hajar");
        n=n%1000;
    }
    if(n>=100){
        num(n/100);
        printf(" shata");
        n=n%100;
    }
    //if(n)
    if(n<100){
        printf(" %d",n);
    }
}

int main(){
    int long long n;
    int count=1;
    while(scanf("%lld",&n)!=EOF){
        printf("%4d. ",count++);
        if(n==0) printf(" 0");
        num(n);
        printf("\n");
    }
}
