#include<stdio.h>

void DrawMap();

int playerX=9, playerY=1;
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

int main()
{
    int dir;

    DrawMap();

    printf("輸入上下左右(1-4進行移動:");
    scanf("%d",&dir);
    if(dir == 1) playerX--;
    else if(dir == 2) playerX++;
    else if(dir == 3) playerY++;
    else if(dir == 4) playerY--;
}

void DrawMap()
{
    int i,j;
    for(i=0;i<10;i++)
    {
        for(j=0;j<10;j++)
        {
            if (playerX==i && playerY==j) printf("☆");
            else
            {
                if(map[i][j] == 0) printf("■");
                else if(map[i][j] == 1) printf("□");
            }
        }
        printf("\n");
    }
}
