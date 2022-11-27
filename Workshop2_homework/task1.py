# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.

# Пример:

# - 6782 -> 23
# - 0,56 -> 11

def sum_of_digits():
    number = float(input("Input your number, please: "))
    sumdig = 0
    number = number *(-1)

    while round(number, 10) % 10 != 0:
        number *= 10
   
    while number > 0:
        digit = number % 10
        sumdig += digit
        number = number // 10
    
    print(f"The sum of digits in this number is: {int(sumdig)}")

sum_of_digits()