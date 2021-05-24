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
        printf("1.�d�ߵ��W�١B2.�d�ߵ��ƥءB3.�q�ʵ��B4.�p���`���B��J-1���}�C\n");
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
    printf("1.���׶� 50��\n2.�i�׶� 60��\n3.�ư��� 70��\n4.���ƶ� 80��\n5.���L�� 85��\n");
}

void countList(void)
{
    int i;
    for(i=0;i<5;i++) printf("%d\n", count[i]);
}

void orderList(void)
{
    int index, number;
    printf("�п�J���s���H�μƥ�\n");
    scanf("%d%d", &index, &number);
    count[index-1] += number;
}

void priceCalculate(void)
{
    int i;
    int total=0;
    for(i=0;i<5;i++) total += price[i] * count[i];
    printf("�`����%d��\n", total);
}
