//Instructions: Write a program that displays the integer part of a number entered by the user on the screen.

//Importing the readline
const readline = require('readline/promises');

//Creating the reading interface
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

async function run() {
  //Asking the user a question
  const answer = await rl.question("Enter a real number: ");
  //Converting the answer to a number
  const r = parseFloat(answer);
  
  //Taking the whole part
  console.log(`The integer part of ${r} is ${Math.trunc(r)}`);

  //Closing the interface
  rl.close();
}

run();
