#include <iostream>
using namespace std;

int t, n, numberOfOpenBracket, result;
char c;

int main()
{
    cin >> t;

    while (t-- > 0) {
        numberOfOpenBracket = 0, result = 0;
        cin >> n;
        while (n-->0)
        {
            cin >> c;
            if (c == '(') numberOfOpenBracket++;
            else if (numberOfOpenBracket > 0) numberOfOpenBracket--;
            else result++;
        }
        cout << result << "\n";
    }
}