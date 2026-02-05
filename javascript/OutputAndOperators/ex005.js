// Statement: Write a program that displays the numbers 4.68805; 4.8; 5.9964; and 5 rounded to 
// three different lines, with the first line showing all numbers rounded 
// to three decimal places, the second to two, and the third to one decimal place.

// Numbers we want to display
const numbers = [4.68805, 4.8, 5.9964, 5];

// First line: 3 decimal places
const line1 = numbers.map(num => num.toFixed(3)).join(' ');
console.log(line1);

// Second line: 2 decimal places
const line2 = numbers.map(num => num.toFixed(2)).join(' ');
console.log(line2);

// Third line: 1 decimal place
const line3 = numbers.map(num => num.toFixed(1)).join(' ');
console.log(line3);
