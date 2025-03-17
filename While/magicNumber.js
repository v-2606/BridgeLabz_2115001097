const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

function findMagicNumber() {
    console.log("Think of a number between 1 and 100!");
    console.log("Answer with 'higher', 'lower', or 'yes' when I guess.");
    
    let min = 1;
    let max = 100;
    let attempts = 0;

    function makeGuess() {
        attempts++;
        // Calculate middle point
        let guess = Math.floor((min + max) / 2);
        
        rl.question(`Is your number ${guess}? (yes/higher/lower): `, (answer) => {
            answer = answer.toLowerCase();
            
            if (answer === 'yes') {
                console.log(`Found your number ${guess} in ${attempts} attempts!`);
                rl.close();
            } else if (answer === 'higher') {
                min = guess + 1;
                if (min <= max) {
                    makeGuess();
                } else {
                    console.log("You must have made a mistake somewhere!");
                    rl.close();
                }
            } else if (answer === 'lower') {
                max = guess - 1;
                if (min <= max) {
                    makeGuess();
                } else {
                    console.log("You must have made a mistake somewhere!");
                    rl.close();
                }
            } else {
                console.log("Please answer with 'yes', 'higher', or 'lower'");
                attempts--; // Don't count invalid attempts
                makeGuess();
            }
        });
    }

    makeGuess();
}

// Handle program exit
rl.on('close', () => {
    process.exit(0);
});

// Start the game
findMagicNumber(); 