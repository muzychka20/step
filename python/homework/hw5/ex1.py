def gcd(a, b):
    if not b:
        return a
    else:
        return gcd(b, a % b)


print(gcd(18, 24))
