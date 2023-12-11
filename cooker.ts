import readline from "readline";

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

let powerOne: boolean = false;
let keepWarm: boolean = false;
const maxWeight: number = 500;
let weight: number = 0;
let start: number = 0;

function cook(): void {
    if (weight === 0) {
        rl.question("Le poids du riz: ", (answer) => {
            weight = parseInt(answer);
            if (weight > maxWeight) {
                console.log("Y a beaucoup trop de riz");
                rl.close();
            } else {
                rl.question("Pour ajouter de l'eau dans le rice cooker, cliquer sur enter", () => {
                    rl.question("Si vous voulez faire cuire tout de suite, cliquer sur le nombre 0 sinon veuillez indiquer dans combien de minute vous voulez commencer la cuisson: ", (startInput) => {
                        start = parseInt(startInput);
                        if (start === 0) {
                            powerOne = true;
                            console.log("Cuisson");
                        } else {
                            console.log("La cuisson commencera dans " + start + " minutes");
                        }
                        keepWarm = true;
                        console.log("Maintien au chaud ");
                        //rl.close();
                        processOption();
                    });
                });
            }
        });
        rl.close;
    } else {
        console.log("Vous ne pouvez pas en ajouter");
        rl.close();
    }
}

function prediction(): void {
    if (weight <= 500 && weight > 300) {
        console.log("Votre cuisson sera finie dans " + (45 + start) + "min");
    } else if (weight <= 300 && weight > 100) {
        console.log("Votre cuisson sera finie dans 35 min");
    } else if (weight <= 100 && weight>0) {
        console.log("Votre cuisson sera finie dans 20 min");
    } else {
        console.log("Y a même pas de riz dans le rice cooker");
    }
    prediction();
}

function processOption(): void {
    rl.question("Entrez votre choix : ", (answer) => {
        let option: number = parseInt(answer);
            
        switch (option) {
            case 1:
                cook();
                //processOption();
                break;
            case 2:
                prediction();
                //processOption();
                break;
            case 3:
                rl.close();
                break;
            default:
                console.log("Option invalide.");
                processOption();
        }   
    });
    
}

processOption();
