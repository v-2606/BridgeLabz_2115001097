function findMaxMin(a, b, c) {
    const operation1 = a + b * c;   
    const operation2 = a % b + c; 
    const operation3 = c + a / b;  
    const operation4 = a * b + c; 

    const results = [operation1, operation2, operation3, operation4];

    console.log("Results:", results);

    const maxValue = Math.max(...results);
    const minValue = Math.min(...results);

    console.log("Maximum Value:", maxValue);
    console.log("Minimum Value:", minValue);
}

const a = parseInt(process.argv[2]);
const b = parseInt(process.argv[3]);
const c = parseInt(process.argv[4]);

findMaxMin(a, b, c);
