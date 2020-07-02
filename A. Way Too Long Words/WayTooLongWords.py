
def main():
    line = int(input())
    for i in range(0, line):
        word = input()
        length = len(word)
        if length <= 10:
            print(word)
        else:
            print(word[0] + str(length-2) + word[length-1])


if __name__ == "__main__":
    main()
