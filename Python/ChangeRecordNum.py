storedScore = 10
recordScore = int
print("Input a score")
numberInput = input()
numberInput = int(numberInput)

if numberInput > storedScore:
    recordScore = numberInput
else:
    recordScore = storedScore

print(recordScore)