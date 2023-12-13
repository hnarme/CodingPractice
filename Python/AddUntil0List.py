def add_until_0(numbers):
    result = 0
    for number in numbers:
        if number == 0:
            break
        result = result + number
    return result
print(add_until_0([1, 2, 0, 4]))