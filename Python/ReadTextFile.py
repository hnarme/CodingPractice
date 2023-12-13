def decode(message_file):
    file = open(message_file)
    print(file.read())
    
decode("message_file.txt")