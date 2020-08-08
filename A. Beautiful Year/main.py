
def main():
    year = int(input(''))+1

    while(1):
        if len(str(year)) == len(set(str(year))):
            break
        else:
            year = int(year) + 1

    print(year)


if __name__ == "__main__":
    main()
