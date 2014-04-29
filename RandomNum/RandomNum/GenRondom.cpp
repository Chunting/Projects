#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
   int i, n;
   time_t t;
   
   n = 12;
   
   /* Intializes random number generator */
   srand((unsigned) time(&t));

   /* Print 5 random numbers from 0 to 11000 */
   for( i = 0 ; i < n ; i++ ) {
      printf("%d\n", rand() % 900);
   }
   system("pause");
   
  return 0;
}