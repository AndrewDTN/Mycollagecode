#include <stdio.h>

long long int sum (long long int n){
    int add = 0;
    while(n >= 10){
        if(n/10>=10){
            add += n%10;
            n=n/10;
        }
        else if(n/10<10){
            add = add+n%10+n/10;
            n = add;
            add = 0;
        }
    }
    return n;
}

int main(){
    long long int n;
    while(scanf("%lld",&n)>0){
        if(n==0) break;
        printf("%lld\n",sum(n));
    }
}
