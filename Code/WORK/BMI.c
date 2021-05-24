#include<stdio.h>

int main(void)
{
    float weight,height;
    float BMI;

    printf("Please enter your weight(KG):");
    scanf("%f",&weight);
    printf("Please enter your height(CM):");
    scanf("%f",&height);
    height=height/100;
    BMI=weight/(height*height);
    printf("Your BMI is %f ",BMI);

    if(BMI < 18.5)
    {
        printf("體重過輕");
    }
    else if(BMI < 24 && BMI >=18.5)
    {
        printf("正常範圍");
    }
    else if(BMI < 27 && BMI >= 24)
    {
        printf("過重");
    }
    else if(BMI < 30 && BMI>= 27)
    {
        printf("輕度肥胖");
    }
    else if(BMI <35 && BMI>=30)
    {
        printf("中度肥胖");
    }
    else
    {
        printf("重度肥胖");
    }
}
