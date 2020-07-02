import math


def main():
    n = input()
    line = input()
    array = line.split(' ')
    numberOfTaxi = 0

    arrayInt = [int(i) for i in array]

    arrayLen = len(arrayInt)
    if arrayInt.count(arrayInt[0]) == arrayLen:
        if arrayInt[0] == 1:
            numberOfTaxi = math.ceil(arrayLen / 4)
        elif arrayInt[0] == 2:
            numberOfTaxi = math.ceil(arrayLen / 2)
        else:
            numberOfTaxi = math.ceil(arrayLen)
    else:
        while (len(arrayInt) > 0):
            num = arrayInt[0]
            del arrayInt[0]
            remainder = 4 - num
            i = 0
            while (remainder > 0 and i < len(arrayInt)):
                try:
                    index = arrayInt.index(remainder)
                    del arrayInt[index]
                    break
                except:
                    num2 = arrayInt[i]
                    if(num2 < remainder):
                        remainder = remainder - num2
                        del arrayInt[i]
                    else:
                        i = i+1

            numberOfTaxi = numberOfTaxi + 1

    print(numberOfTaxi)


if __name__ == "__main__":
    main()
