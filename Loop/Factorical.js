function factorial(n) {
    if (n < 0) {
        console.log("Factorial for negative numbers doesn't exist.");
        return;
    }

    let fact = 1;
    for (let i = 1; i <= n; i++) {
        fact *= i;
    }

    console.log(`Factorial of ${n} is: ${fact}`);
}


const num = parseInt(process.argv[2]);

factorial(num);
