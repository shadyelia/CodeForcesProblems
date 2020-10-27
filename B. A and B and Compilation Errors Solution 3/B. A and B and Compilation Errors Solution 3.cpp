#include <iostream>
using namespace std;

template <class T>
inline void read(T& res) {
    char c;res = 0;
    while ((c = getchar()) < '0' || c > '9');
    while (c >= '0' && c <= '9') {
        res = res * 10 + (c - '0');
        c = getchar();
    }
}


int sum1, sum2, sum3, length, number;
int main()
{
    read(length);
    for (int i = 0;i < length;i++) {
        read(number);
        sum1 += number;
    }
    for (int i = 0;i < length-1;i++) {
        read(number);
        sum2 += number;
    }
    for (int i = 0;i < length -2;i++) {
        read(number);
        sum3 += number;
    }
    printf("%d\n", sum1 - sum2);
    printf("%d\n", sum2 - sum3);
}
