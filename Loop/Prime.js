function isPrime(num) {
    if (num <= 1) {
        return false;
    }
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) {
            return false;
        }
    }
    return true;
}


const num = parseInt(process.argv[2]);

if (isPrime(num)) {
    console.log(`${num} is a Prime Number`);
} else {
    console.log(`${num} is Not a Prime Number`);
}
