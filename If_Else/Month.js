
const args = process.argv.slice(2);

// Extract day and month
const day = parseInt(args[0], 10);
const month = parseInt(args[1], 10);

const isInRange = (
  (month === 3 && day >= 20) ||
  (month === 4) ||
  (month === 5) ||
  (month === 6 && day <= 20)
);


console.log(isInRange);
