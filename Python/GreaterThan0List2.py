def positive_numbers(numbers):
    numlist = []
    for number in numbers:
        if number > 0:
            numlist = numlist + [number]
    return numlist

print(positive_numbers([-10, 10, 20]))