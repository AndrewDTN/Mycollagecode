#include<stdio.h>

void foodList(void);
void countList(void);
void orderList(void);
void priceCalculate(void);

int price[5]={50,60,70,80,85};
int count[5]={0,0,0,0,0};

int main(void)
{
    int command;

    do{
        printf("1.查詢菜單名稱、2.查詢菜單數目、3.訂購菜單、4.計算總價、輸入-1離開。\n");
        scanf("%d", &command);
        if(command == 1) foodList();
        else if(command == 2) countList();
        else if(command == 3) orderList();
        else if(command == 4) priceCalculate();
        else if(command == -1) break;
    }while(1);
}

void foodList(void)
{
    printf("1.滷肉飯 50元\n2.爌肉飯 60元\n3.排骨飯 70元\n4.魚排飯 80元\n5.雞腿飯 85元\n");
}

void countList(void)
{
    int i;
    for(i=0;i<5;i++) printf("%d\n", count[i]);
}

void orderList(void)
{
    int index, number;
    printf("請輸入菜單編號以及數目\n");
    scanf("%d%d", &index, &number);
    count[index-1] += number;
}

void priceCalculate(void)
{
    int i;
    int total=0;
    for(i=0;i<5;i++) total += price[i] * count[i];
    printf("總價為%d元\n", total);
}
