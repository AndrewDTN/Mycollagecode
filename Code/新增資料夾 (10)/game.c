#include<stdio.h>

int main()
{
    int playerX=9, playerY=1;
    int i,j;
    int map[10][10]={{0,0,0,0,0,0,0,1,0,0},
                    {0,1,1,1,1,0,0,1,0,0},
                    {0,1,0,0,1,1,1,1,0,0},
                    {0,1,0,1,1,0,0,0,0,0},
                    {0,0,0,1,0,0,0,0,1,0},
                    {0,0,0,1,1,1,0,1,1,0},
                    {0,1,1,0,0,1,0,1,0,0},
                    {0,0,1,0,0,1,0,1,0,0},
                    {0,1,1,1,1,1,1,1,0,0},
                    {0,1,0,0,0,0,0,0,0,0}};
    for(i=0;i<10;i++)
    {
        for(j=0;j<10;j++)
        {
            if(map[i][j] == 0) printf("��");
            else if(map[i][j] == 1) printf("  ");
        }
        printf("\n");
    }
}
