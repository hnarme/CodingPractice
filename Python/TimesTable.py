print("See any Times Tables up to 10")
print("\n" + "Input a number to see the Times Tables for the chosen number up to 10")
numberInput = input()
numberInput = int(numberInput)

i = 0

while i < 60:
  i += 1
  print(i * numberInput)