#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char country[ 2005 ][ 75 ];
char name[ 2005 ][ 75 ];

int cmp( const void* a, const void* b )
{
	char *p = (char *)a;
	char *q = (char *)b;
	return strcmp( p, q );
}

int main()
{
	int n;
	while ( scanf("%d",&n) != EOF && n )  {
		getchar();
		for ( int i = 0 ; i < n ; ++ i ) {
			scanf("%s",country[ i ]);
			gets( name[ i ] );
		}
		qsort( country, n, sizeof( char )*75, cmp );

		printf("%s",country[ 0 ]);
		int count = 1;
		for ( int i = 1 ; i < n ; ++ i ) {
			if ( strcmp( country[ i ], country[ i-1 ] ) ) {
				printf(" %d\n",count);
				count = 1;
				printf("%s",country[ i ]);
			}else ++ count;
		}
		printf(" %d\n",count);
	}
	return 0;
}
