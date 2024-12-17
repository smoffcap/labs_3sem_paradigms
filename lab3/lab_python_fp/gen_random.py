from random import randint
def gen_random(num_count, begin, end):
    for x in range(num_count):
        yield randint(begin, end)



def main():
    for i in gen_random(5, 1, 3):
        print(i)



if __name__ == '__main__':
    main()