from typing import List

def contains_duplicate(words: List[str]) -> bool:
    count = len(words)
    my_set = set(words)
    my_set_count = len(my_set)
    if count > my_set_count:
        return True
    else:
        return False

# do not modify code below this line
print(contains_duplicate(["hello", "world", "hello"]))
print(contains_duplicate(["hello", "world", "i", "am", "great"]))
print(contains_duplicate(["hello", "hello", "hello"]))
print(contains_duplicate(["Hello", "hellooo", "hello"]))
