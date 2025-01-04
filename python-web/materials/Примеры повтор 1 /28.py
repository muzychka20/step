#Поиск в словаре

users = [
 {'name': 'Hanna', 'age': 10, 'login':'user56'},
 {'name': 'Mark', 'age': 15, 'login':'usER111'},
 {'name': 'Jane', 'age': 17, 'login':'superGirl'},
 {'name': 'Jack', 'age': 7, 'login':'userJack'}
]

keyName=input("Input info type:")
keyValue=input("Input info value:")
isElementFound=False
for user in users:
    if user.get(keyName)==keyValue:
        print("Element is found!")
for key,val in user.items():
    print("{}:{}".format(key,val))
    isElementFound=True
    break
if isElementFound==False:
    print("Element is not found!")