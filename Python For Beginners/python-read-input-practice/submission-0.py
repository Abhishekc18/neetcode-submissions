def add_two_numbers() -> int:
    int_list = input().split(",")
    val = 0
    for i in int_list:
        val += int(i)
    return val


# do not modify below this line
print(add_two_numbers())
print(add_two_numbers())
print(add_two_numbers())
print(add_two_numbers())
