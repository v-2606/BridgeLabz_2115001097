

function numberToWord(num) {
    const words = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"];

    if (num >= 0 && num <= 9) {
        console.log(words[num]);
    } else {
        console.log("Invalid input. Please enter a single-digit number.");
    }
}


const input = process.argv[2];
numberToWord(input);
