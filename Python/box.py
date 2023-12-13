import sys

num = int(input("Enter rectangle size:"))
star1 = "*"
star2 = "**"
star3 = "**** "
star4 = "****** "
star5 = "******** "


for i in range(num):
    for j in range(i):
        print(star2, star2)
        print("")
        print(star3, star3)
        print(star3, star3)
        print("")
        print(star4, star4)
        print(star1, "  ", star1, "",star1, "  ", star1)
        print(star4, star4)
        print("")
    print()