
def main():
    line = input()
    array = line.split(' ')
    k = int(array[0])
    n = int(array[1])
    w = int(array[2])

    sum = 0

    for i in range(0, w):
        sum = sum + ((i+1)*k)

    if(sum <= n):
        print(0)
    else:
        print(sum-n)


if __name__ == "__main__":
    main()
