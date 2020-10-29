#include <iostream>

using namespace std;

int n;
long long a, b, x, y;
int main()
{
    cin >> n;
    while (n-->0)
    {
        cin >> x >> y >> a >> b;

        if (x > 0 && y > 0) {
            if (a * 2 > b)
            {
                if (x > y) cout << (x - y) * a + y * b << "\n";
                else if (x < y) cout << (y - x) * a + x * b << "\n";
                else cout << x * b << "\n";
            }
            else {
                cout << (x + y) * a << "\n";
            }
        }
        else {
           cout << (x + y) * a << "\n";
        }
    }
}
