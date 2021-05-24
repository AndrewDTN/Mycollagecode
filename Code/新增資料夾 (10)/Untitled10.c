#include<stdio.h>
int linearSearch(int find);
int binarySearch(int find);
int data[10]={2,4,6,8,10,12,37,45,68,89};

int main()
{
    int index=linearSearch (6);
    printf("%d\n",index);

    index = binarySearch(12);
    printf("%d\n",index);
}

int linearSearch(int find)
{
    int i,index=-1;
    for(i=0;i<10;i++)
    {
        if(data[i]==find)
        {
            index=i;
            break;
        }
    }
    return index;
}

int binarySearch(int find)
{
    int i;
    int low=0,high=9;
    int middle=-1;

    while(low <= high)
    {
        middle=(high+low)/2;
        if(data[middle]==find) return middle;
        else
        {
            if(data[middle] > find) high = middle-1;
            else low=middle+1;
        }
    }
    return -1;
}
