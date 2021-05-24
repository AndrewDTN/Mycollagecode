#include<stdio.h>//command=1時要不PRINT

int penUp(void);
void penDown(void);
int turnRight(void);
int turnLeft(void);
int goForword(void);
void theResult(void);

int floor[50][50]={0};

int k=1;
int l=1;
int turtlex=0;
int turtley=0;

int main()
{
    int a,b,c,d;
    int e=0;
    int command;
    do
    {
        scanf("%d",&command);
        if(command==1)
        {
            e--;
            floor[turtlex][turtley]=penUp();
        }
        else if(command==2)
        {
            e++;
            penDown();
        }
        else if(command==3)
        {
            k++;
            l=turnRight();
        }
        else if(command==4)
        {
            k--;
            l=turnLeft();
        }
        else if(command==5)
        {
            if(e%2==1)
            {
                if(l%2==0)
                {
                    a=goForword();
                    turtlex+=a;
                    d=turtlex-a;
                    if(a>0)
                    {
                        for(turtlex;turtlex>=d;turtlex--) penDown();
                        turtlex+=(a+1);
                    }
                    else if(a<0)
                    {
                        for(turtlex;turtlex<=d;turtlex++) penDown();
                        turtlex+=(a-1);
                    }

                }
                else
                {
                    b=goForword();
                    turtley+=b;
                    c=turtley-b;
                    if(b>0)
                    {
                        for(turtley;turtley>=c;turtley--) penDown();
                        turtley+=(b+1);
                    }
                    else if(b<0)
                    {
                        for(turtley;turtley<=c;turtley++) penDown();
                        turtley+=(b-1);
                    }
                }
            }
            else if(e%2==0)
                if(l%2==0)
                {
                    a=goForword();
                    turtlex+=a;
                }
                else
                {
                    b=goForword();
                    turtley+=b;
                }
        }
        else if(command==6) theResult();
        else if(command==9) break;
        printf("%d %d\n",turtley,turtlex);
    }
    while(1);
}

int penUp(void)
{
    int m;
    if(floor[turtlex][turtley]==m) return m;
}

void penDown(void)
{
    floor[turtlex][turtley]=1;
}

int turnRight(void)
{
    if(k%4==0) return 0;
    else if(k%4==1) return 1;
    else if(k%4==2) return 2;
    else if(k%4==3) return 3;
}

int turnLeft(void)
{
    if(k%4==0) return 0;
    else if(k%4==1) return 1;
    else if(k%4==2) return 2;
    else if(k%4==3) return 3;
}

int goForword(void)
{
    int a;
    printf("請輸入步數: ");
    scanf("%d",&a);
    if(l==0) return a*(-1);
    else if(l==1) return a*1;
    else if(l==2) return a*1;
    else if(l==3) return a*(-1);
}

void theResult(void)
{
    for(turtlex=0;turtlex<50;turtlex++)
    {
        for(turtley=0;turtley<50;turtley++)
        {
            if(floor[turtlex][turtley]==1) printf("*");
            else if(floor[turtlex][turtley]==0)printf(" ");
        }
        printf("\n");
    }
}
