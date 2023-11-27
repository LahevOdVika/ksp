const readline = require('readline');
const fs = require('fs');

const filePath = './vstup.txt';
let lineNumber = 1; // čítač řádků
let N = 0; // počet stringů k načtení

const readInterface = readline.createInterface({
    input: fs.createReadStream(filePath),
    output: undefined,
    console: false
});

let dict = {};
let nejcastejsi = 0;
let nejcastejsiPrijmeni = "";

readInterface.on('line', function(line) {
    if (line === "") {
        return;
    }
    
    if (lineNumber === 1) {
      N = parseInt(line); // převod řetězce na číslo
    } else if (lineNumber <= N + 1) {
        if (dict[line] == undefined) {
            dict[line] = 1;
        }
        else {
            dict[line] += 1;
        }
    } else {
      readInterface.close(); // ukončení čtení po načtení všech řádků
    }
    
    lineNumber++;
});

readInterface.on('close', function() {
    for (let key in dict) {
        let value = dict[key];
        if (nejcastejsi < value) {
            nejcastejsi = value;
            nejcastejsiPrijmeni = key;
        }
    }
    console.log(nejcastejsiPrijmeni + " " + nejcastejsi);
});



