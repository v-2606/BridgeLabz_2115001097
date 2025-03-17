function gamble() {
    let money = 100; 
    const goal = 200; 
    let wins = 0;
    let totalBets = 0;

    while (money > 0 && money < goal) {
        totalBets++;

        const betResult = Math.random() < 0.5; 

        if (betResult) {
            money++; // Win
            wins++;
        } else {
            money--; // Lose
        }
    }

    console.log(`\n💰 Final Money: Rs ${money}`);
    console.log(`🏆 Total Wins: ${wins}`);
    console.log(`🎲 Total Bets: ${totalBets}`);
}

gamble();
