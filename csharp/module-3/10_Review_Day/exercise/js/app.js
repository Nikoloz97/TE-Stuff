const qOne = ['2*3', 6, 7, 8, 9]
const qTwo = ['3*4', 12, 7, 8, 9]
const qThree = ['4*5', 20, 7, 8, 9]
const qFour = ['5*6', 30, 7, 8, 9]
const qFive = ['6*7', 42, 7, 8, 9]
const qSix = ['8*9', 72, 7, 8, 9]
const qSeven = ['10*11', 110, 7, 8, 9]
const qEight = ['11*12', 132, 7, 8, 9]
const qNine = ['12*13', 156, 7, 8, 9]
const qTen = ['13*14', 182, 7, 8, 9]

const allProblems = [qOne, qTwo, qThree, qFour, qFive, qSix, qSeven, qEight, qNine, qTen]

//Generate a random number from min -> max (not including max)
function getRandomNumber(min, max) {
    // Round up the min number
    min = Math.ceil(min);
    // Round down the max number
    max = Math.floor(max);
    // Math.random = generates random decimal 0 -> 1
    // Math.floor = excludes the max parameter from consideration
    return Math.floor(Math.random() * (max - min) + min)
}

function GenerateProblem() {
    // Grab random question
    const randNum = getRandomNumber(0, 10);
    const randomQues = allProblems[randNum];

    // Throw index of 0 on expression
    const expressionDiv = document.getElementsByClassName('expression show-hide');
    const expressionDivArray = Array.from(expressionDiv);
    expressionDivArray[0].textContent = randomQues[0];

    // Throw index 1-4 (random) as answer options
    const answerOptions = document.querySelectorAll('li');
    answerOptions.forEach((option) => {
        option.textContent = randomQues[1]
    });
}

function DisplayCorrectAnswer() {

}


document.addEventListener('DOMContentLoaded', () => {
    GenerateProblem();

})