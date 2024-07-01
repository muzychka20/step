statistics = {
    'amount_chars': 0,
    'amount_lines': 0,        
    'amount_vowels': 0,
    'amount_consonants': 0,
    'amount_digits': 0        
}

   
def check_char_for_vowel(char):
    vowels = 'aeiou'
    for vowel in vowels:
        if char == vowel or char == vowel.upper():
            return 1
    return 0


def check_char_for_consonant(char):
    consonants = 'bcdfghjklmnpqrstvwxyz'
    for consonant in consonants:
        if char == consonant or char == consonant.upper():
            return 1
    return 0        


def check_char_for_digit(char):
    return 1 if char.isnumeric() else 0                


def read_file():
    with open('ex2.txt', 'r') as file:
        while True:
            line = file.readline()[:-1]
            if not line:
                break
            statistics['amount_lines'] += 1
            for char in line:
                statistics['amount_chars'] += 1              
                statistics['amount_digits'] += check_char_for_digit(char)
                statistics['amount_vowels'] += check_char_for_vowel(char)              
                statistics['amount_consonants'] += check_char_for_consonant(char)


def write_statistics():
    with open('ex2_statistics.txt', 'w') as file:
        for key, value in statistics.items():
            file.write(f"{key}: {value}\n")
            

read_file()
write_statistics()
