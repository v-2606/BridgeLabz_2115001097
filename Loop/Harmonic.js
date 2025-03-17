function harmonicNumber(n) {
    if (n <= 0) {
        console.log("Please enter a positive number.");
        return;
    }

    let harmonic = 0.0;

    for (let i = 1; i <= n; i++) {
        harmonic += 1 / i;
    }

    console.log(`Harmonic Number H(${n}) = ${harmonic.toFixed(4)}`);
}


const n = parseInt(process.argv[2]);
harmonicNumber(n);
