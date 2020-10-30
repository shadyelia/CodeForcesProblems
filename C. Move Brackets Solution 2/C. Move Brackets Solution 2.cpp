#include <iostream>
#include <string>
#include <vector>
using namespace std;

int t, n, numberOfOpenBracket, result;

int main()
{
    cin >> t;
    std::vector<string> myList;

    while (t-- > 0) {
        string data;
        
        cin >> n >> data;
        myList.push_back(data);
    }

    std::vector<string> data;

    for (int i = 0;i < myList.size();i++) {
        string const& x = myList[i];
        numberOfOpenBracket = 0, result = 0;

        for (int i = 0;i < x.size();i++)
        {
            if (x[i] == '(') numberOfOpenBracket++;
            else if (numberOfOpenBracket > 0) numberOfOpenBracket--;
            else result++;
        }
        cout << result << "\n";
    }
}




void main2()
{
    cin >> t;

    while (t-- > 0) {
        string data;
        numberOfOpenBracket = 0, result = 0;
        cin >> n >> data;
        for (int i = 0;i < n;i++)
        {
            if (data[i] == '(') numberOfOpenBracket++;
            else if (numberOfOpenBracket > 0) numberOfOpenBracket--;
            else result++;
        }
        cout << result << "\n";
    }
}