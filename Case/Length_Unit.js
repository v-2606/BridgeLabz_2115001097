function unitConversion(choice, value) {
    switch (choice) {
        case 1: 
            console.log(`${value} Feet = ${value * 12} Inches`);
            break;
        case 2: 
            console.log(`${value} Feet = ${(value * 0.3048).toFixed(2)} Meters`);
            break;
        case 3: 
            console.log(`${value} Inches = ${(value / 12).toFixed(2)} Feet`);
            break;
        case 4: 
            console.log(`${value} Meters = ${(value * 3.28084).toFixed(2)} Feet`);
            break;
        default: 
            console.log("Invalid choice. Please select between 1 to 4.");
    }
}


const choice = parseInt(process.argv[2]);  
const value = parseFloat(process.argv[3]); 

unitConversion(choice, value);
