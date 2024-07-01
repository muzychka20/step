



### ------------ ZAV 1 ------------ ###

# with open('source1.txt', 'a') as file:
#     file.write('спасите, меня держут в заложниках 0_0' + '\n')

### ------------ ZAV 2 ------------ ###
    
# with open('file_one.txt', 'r') as file:
#     for line in file:
#         with open('file_two.txt', 'a') as file:
#             file.write(line)

### ------------ ZAV 3 ------------ ###

# def filter_words(source_file, result_file):
#     with open('file_one.txt', 'r') as file_one, open('file_two.txt', 'w') as file_two:
#         for line in file_one:
#             file_two.write(line[::-1] + '\n')


# filter_words('source1.txt', 'result11.txt')

### ------------ ZAV ??? ------------ ###
import random

sites: list = [
    'exploreverse.com',
    'techinnovatehub.com',
    'creativemindsconnect.com',
    'globalimpacthub.org',
    'stellarideas.net',
    'discoverinsights.com',
    'nexusnetworks.io',
    'innovatopia.com',
    'quantumquest.net',
    'radiantreach.org',
    'codecrafters.io',
    'cosmoscollide.com',
    'ideavortex.net',
    'synthesizehub.com',
    'quantumquasar.io'
    ]


time: list = [
    '03:27',
    '14:52',
    '08:09',
    '19:34',
    '11:21',
    '05:48',
    '17:13',
    '09:57',
    '23:06',
    '15:39',
    '07:45',
    '20:18',
    '12:30',
    '02:53',
    '18:47'
]

codes: list = [
    '403',
    '404',
    '200'
    # '202',
    # '167',
    # '999',
    # '44',
    # '765',
    # '123',
    # '098',
    # '666',
    # '421',
    # '89',
    # '11',
    # '42',
    # '09'
]


def generate(file_path: str, number: int, sites: list, times: list, codes: list):
    with open(file_path, 'w') as file:
        for i in range(number):

            site = random.choice(sites)
            time = random.choice(times)
            code = random.choice(codes)

            entry = f"{site}, {time}, {code}" + '\n'
            file.write(entry)








        
    





generate(file_path='Logs1802.txt', number=20, sites=sites,times=time, codes=codes)
