#include <stdio.h>

void generateSquares(int);

int main() {
  
    int x;
    scanf("%d", &x);

  generateSquares(x);
}

void generateSquares(int x){

    if(x == 0){
        return; // termina o programas
    }
    
    if (x % 2 == 0){
        generateSquares(x - 2);
    }
    printf("%d^2 = %d\n", x, (x * x));
}