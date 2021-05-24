#include<stdio.h>
#include<math.h>

double distance (int x1,int y1,int x2,int y2);
int main()
{
    double a=distance (2,2,1,1);
    printf("%f",a);
}

double distance (int x1,int y1,int x2,int y2)
{
    double j,k;
    if (x1>=x2 && y1>=y2)
    {
        j=pow(x1-x2,2);
        k=pow(y1-y2,2);
        return pow(j+k,0.5);
    }
    else if (x1>=x2 && y2>y1)
    {
        j=pow(x1,2)-pow(x2,2);
        k=pow(y2,2)-pow(y1,2);
        return pow(j,0.5)+pow(k,0.5);
    }
    else if (x2>x1 && y1>=y2)
    {
        j=pow(x2,2)-pow(x1,2);
        k=pow(y1,2)-pow(y2,2);
        return pow(j,0.5)+pow(k,0.5);
    }
    else if (x2>x1 && y2>y1)
    {
        j=pow(x2,2)-pow(x1,2);
        k=pow(y2,2)-pow(y1,2);
        return pow(j,0.5)+pow(k,0.5);
    }
}
