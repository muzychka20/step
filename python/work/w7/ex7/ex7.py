array = [
'hello',
'#world,',
'bask&&etball',
'world',
'#basketballworld',
'basketball',
'&&&&&&&&&&&&',
'rgdr,',
]

with open('./ex7_res.txt', 'w') as file_write:
    for line in array:
        file_write.write(line + '\n')