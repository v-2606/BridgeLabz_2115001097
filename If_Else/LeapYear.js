const args = process.argv.slice(2);
const year = parseInt(args[0], 10);

if (isNaN(year) || year < 1000 || year > 9999) {
  console.log("Invalid input. Please enter a 4-digit year.");
} else {
  const isLeapYear = (year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0);
  console.log(isLeapYear ? "Leap Year" : "Not a Leap Year");
}
