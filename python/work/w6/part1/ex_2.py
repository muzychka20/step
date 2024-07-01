
#1
def division(a , b):
    try:       
        result = a / b
    except ZeroDivisionError:
        print("b не може дорівнювати нулю")
    except ValueError:
        print("a і b числа")
    else:
        return result
    
a = int(input("a = "))
b = int(input("b = "))   

print(division(a, b))


#2
def division2(a , b):      
    result = a / b
    return result
   
 
a = int(input("a = "))
b = int(input("b = "))   
 
try:
    print(division2(a, b))
except ZeroDivisionError:
    print("b не може дорівнювати нулю")
except ValueError:
    print("a і b числа")