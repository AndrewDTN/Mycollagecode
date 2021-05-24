#include<stdio.h>

int main()
{
    FILE *fp;

    fp = fopen("temp.txt","w");

    fprintf(fp, "Hello World 123");
    fprintf(fp, "Hello World 123");

    fclose(fp);
}
