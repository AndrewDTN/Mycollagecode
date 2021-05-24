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

    do
    {
        printf("輸入上下左右(1-4進行移動),-1結束遊戲:");
        scanf("%d",&dir);
        system("cls");
        if(dir == 1)
        {
            if(map[playerX-1][playerY]==1) playerX--;
            else printf("輸入錯誤\n");
        }
        else if(dir == 2)
        {
            if(map[playerX+1][playerY]==1) playerX++;
            else printf("輸入錯誤\n");
        }
        else if(dir == 3)
        {
            if(map[playerX][playerY+1]==1) playerY++;
            else printf("輸入錯誤\n");
        }
        else if(dir == 4)
        {
            if(map[playerX][playerY-1]==1) playerY--;
            else printf("輸入錯誤\n");
        }
        DrawMap();
    }while(dir!=-1);

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
