// 01. Еmployees

function solve(inputArr){
    class Employee{
        constructor (name, personalNumber){
            this.name = name
            this.personalNumber = personalNumber
        }

        printInfo(){
            return  `Name: ${this.name} -- Personal Number: ${this.personalNumber}` 
        }
    }

    for (const element of inputArr) {
        let name = element
        let personalNumber = name.length

        let employee = new Employee(name, personalNumber)
        console.log(employee.printInfo())
    }
}


// 02. Towns 
function towns(inputArr){
    class Town{
        constructor (name, lat=0, long=0){
            this.town = name
            this.latitude = lat
            this.longitude = long
        }
    }

    for (const element of inputArr) {
        let [name, latitudeStr, longitudeStr] = element.split(' | ')
        let latitude = Number(latitudeStr).toFixed(2)
        let longitude = Number(longitudeStr).toFixed(2)

        let city = new Town(name, latitude, longitude)
        console.log(`{ town: '${city.town}', latitude: '${city.latitude}', longitude: '${city.longitude}' }`)
    }
}



// 03. Store Provision
function storeProvision (currentStock, orderedProducts){
    let store = {}

    for (let i = 0; i < currentStock.length; i+=2) {
        let productName = currentStock[i];
        let quantity = Number(currentStock[i+1])
        
        store[productName] = quantity
    }

    for (let i = 0; i < orderedProducts.length; i+=2) {
        let productName = orderedProducts[i];
        let quantity = Number(orderedProducts[i+1])
        
        if(store.hasOwnProperty(productName)){
            store[productName] += quantity
        } else {
            store[productName] = quantity
        }
    }

    for (const key in store) {
        console.log(`${key} -> ${store[key]}`)
    }
}


// 04. Movies
function movies (inpurArr){
    let allMovies = []

    for (const commandLine of inpurArr) {
        if (commandLine.startsWith('addMovie')){

            let movieName = commandLine.substring(9)
            allMovies.push({'name': movieName}) 

        } else if (commandLine.includes('directedBy')) {
            let [movieName, directorName] = commandLine.split(' directedBy ')

            let movie = allMovies.find(m => m.name === movieName) 

            if(movie) {
                movie.director = directorName 
            }
        } else if (commandLine.includes('onDate')){
            let [movieName, movieDate] = commandLine.split(' onDate ')

            let movie = allMovies.find(m => m.name === movieName)

            if(movie){
                movie.date = movieDate 
            }
        }
    }

    for (const movie of allMovies) {
        if(movie.director && movie.date){
            console.log(JSON.stringify(movie))
        }
    }
}


// 05. Class Vehicle
class Vehicle{
    constructor (type, model, parts, fuel){
        this.type = type
        this.model = model
        this.parts = {
            engine: parts.engine,
            power: parts.power,
            quality: parts.engine * parts.power
        }
        this.fuel = fuel
    }

    drive(fuelLoss){
        this.fuel -= fuelLoss
    }
}


// 06. Characters in Range
function charactersInRange(a, b){
    let start = Math.min(a.charCodeAt(), b.charCodeAt())
    let end = Math.max(a.charCodeAt(), b.charCodeAt())

    let chars = []

    for (let i = start + 1; i < end; i++) {
        chars.push(String.fromCharCode(i)) 
    }

    console.log(chars.join(' '))
}



// 07. Odd And Even Sum
function oddAndEvenSum(num){
    let oddSum = 0;
    let evenSum = 0;
    let digitsArray = num.toString().split('');

    for (const digit of digitsArray) {
        let currentDigit = Number(digit)  

        if (currentDigit % 2 === 0){
            evenSum += currentDigit
        } else {
            oddSum += currentDigit
        }
    }

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`)
}


// 08. Palindrome Integers
function palindromeIntegers(inputArr){
    for (const number of inputArr) {
        console.log(isPalindrome(number))
    }

    function isPalindrome(num){
        let stringNum = num.toString()
        let reversedStringNum = stringNum.split('').reverse().join('')

        if (stringNum === reversedStringNum){
            return true
        } else {
            return false
        }
    }
}

function secondSolution(inputArr){
    for (const element of inputArr) {
        console.log(element == element.toString().split('').reverse().join(''))
    }
}


// 09. Perfect Number
function perfectNumber(num){
    let result = 0;

    for (let i = 1; i < num; i++) {
        if (num % i === 0){ 
            result += i
        } 
    }

    if (num === result){
        console.log('We have a perfect number!')
    } else {
        console.log('It\'s not so perfect.')
    }
}



// 10. Factorial Division
function factorialDivision(firstNum, secondNum) {
    let factorial1 = factorial(firstNum);
    let factorial2 = factorial(secondNum);
    let result = factorial1 / factorial2

    return result.toFixed(2);

    function factorial(num) {
        let factorial = 1;
        for (let i = 1; i <= num; i++) {
            factorial *= i;
        }
        return factorial;
    }
}