#include<stdio.h>
#include<string.h>

char table[200];
int main()
{
	table['A']='A';
	table['B']=' ';
	table['C']=' ';
	table['D']=' ';
	table['E']='3';
	table['F']=' ';
	table['G']=' ';
	table['H']='H';
	table['I']='I';
	table['J']='L';
	table['K']=' ';
	table['L']='J';
	table['M']='M';
	table['N']=' ';
	table['O']='O';
	table['P']=' ';
	table['Q']=' ';
	table['R']=' ';
	table['S']='2';
	table['T']='T';
	table['U']='U';
	table['V']='V';
	table['W']='W';
	table['X']='X';
	table['Y']='Y';
	table['Z']='5';

	table['1']='1';
	table['2']='S';
	table['3']='3';
	table['4']=' ';
	table['5']='Z';
	table['6']=' ';
	table['7']=' ';
	table['8']='8';
	table['9']=' ';

	char c[1000];
	int i,len,mid;
	int mir,rev;
	while(scanf("%s",c)!=EOF)
	{
		mir = 1;
		rev = 1;
		len = strlen(c);
		mid = len/2;
		for(i=0;i<=mid;i++)
		{
			if(c[i]!=table[c[len-i-1]])
			{
				mir=0;
			}
			if(c[i]!=c[len-i-1])
			{
				rev=0;
			}
		}

		if(mir==1 && rev ==1)
		{
			printf("%s -- is a mirrored palindrome.\n\n",c);
		}
		else if(mir==1 && rev ==0)
		{
			printf("%s -- is a mirrored string.\n\n",c);
		}
		else if(mir==0 && rev ==1)
		{
			printf("%s -- is a regular palindrome.\n\n",c);
		}
		else if(mir==0 && rev ==0)
		{
			printf("%s -- is not a palindrome.\n\n",c);
		}
	}
}
