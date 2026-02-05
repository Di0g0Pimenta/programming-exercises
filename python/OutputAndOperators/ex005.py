# Statement: Write a program that displays the numbers 4.68805; 4.8; 5.9964; and 5 rounded to 
# three different lines, with the first line showing all numbers rounded 
# to three decimal places, the second to two, and the third to one decimal place.

# List of numbers to display
numbers = [4.68805, 4.8, 5.9964, 5]

# First line: 3 decimal places
line1 = " ".join(f"{num:.3f}" for num in numbers)
print(line1)

# Second line: 2 decimal places
line2 = " ".join(f"{num:.2f}" for num in numbers)
print(line2)

# Third line: 1 decimal place
line3 = " ".join(f"{num:.1f}" for num in numbers)
print(line3)
