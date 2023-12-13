def is_uppercase(letter):
    return letter.isupper()

def initials(string):
    result = ""
    for letter in string:
        if is_uppercase(letter):
            result = result + letter
    return result

print(initials("How Everyone Laughed Like Orangutans"))