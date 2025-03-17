function flipCoin() {
    return Math.random() < 0.5 ? "Heads" : "Tails";
}

function flipTillEleven() {
    let headsCount = 0;
    let tailsCount = 0;

    while (headsCount < 11 && tailsCount < 11) {
        const result = flipCoin();
        console.log(result);

        if (result === "Heads") {
            headsCount++;
        } else {
            tailsCount++;
        }
    }

    console.log(`\n ${headsCount === 11 ? "Heads" : "Tails"} wins 11 times!`);
}

flipTillEleven();
