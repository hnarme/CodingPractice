def unique(strings):
    result = ""
    for string in strings:
        if string != result:
            result = string + result
    return result

print(unique("hello my name is hannah"))