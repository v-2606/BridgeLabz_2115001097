
function getRandom3DigitNumber() {
    return Math.floor(100 + Math.random() * 900);
  }
 
  const numbers = Array.from({ length: 5 }, getRandom3DigitNumber);
  
  
  const minValue = Math.min(...numbers);
  const maxValue = Math.max(...numbers);
  
 
  console.log("Generated Numbers:", numbers);
  console.log("Minimum Value:", minValue);
  console.log("Maximum Value:", maxValue);
  