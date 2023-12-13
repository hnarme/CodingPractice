colors = ["red", "green", "blue"]

for color1 in colors:
    for color2 in colors:
        if color1 == color2:
            continue
        print(color1 + "-" + color2)