import sys


def main():
    line = input()
    n = int(line)

    for i in range(0, n):
        if i % 2 == 0:
            sys.stdout.write('I hate ')
        else:
            sys.stdout.write('I love ')

        if(i != n-1):
            sys.stdout.write('that ')

    sys.stdout.write('it')


if __name__ == "__main__":
    main()
