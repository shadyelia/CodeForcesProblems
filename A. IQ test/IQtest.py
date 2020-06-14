
def main():
    n = input()
    line = input()
    array = line.split(' ')
    for i in range(0, len(array)):
        array[i] = int(array[i])
    index = 0

    even = sum(1 for f in array if f % 2 == 0)

    if even == 1:
        for i in range(0, len(array)):
            if (array[i] % 2 == 0):
                index = i + 1
                break
    else:
        for i in range(0, len(array)):
            if (array[i] % 2 != 0):
                index = i + 1
                break

    print(index)


if __name__ == "__main__":
    main()
