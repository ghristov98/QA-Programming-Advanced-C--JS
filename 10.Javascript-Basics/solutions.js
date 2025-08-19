'use strict'
//01. Multiply the Number by 2

function solve(num){
    return num * 2
}

console.log(solve(5))

//02. Student Information

function solve(name, age, grade){
    console.log(`Name: ${name}, Age: ${age}, Grade: ${grade.toFixed(2)}`)
}

solve('Pesho', 22, 5.9)

//03. Excellent Grade

function solve(grade){
    if (grade >= 5.50){
        console.log('Excellent')
    } else {
        console.log('Not excellent')
    }
}

solve(5.9)

//04. Month Printer

function solve(num){

    let result;

    switch(num){
        case 1:
            result = 'January'
            break
        case 2:
            result = 'February'
            break
        case 3:
            result = 'March'
            break
        case 4:
            result = 'April'
            break
        case 5:
            result = 'May'
            break
        case 6:
            result = 'June'
            break
        case 7:
            result = 'July'
            break
        case 8:
            result = 'August'
            break
        case 9:
            result = 'September'
            break
        case 10:
            result = 'October'
            break
        case 11:
            result = 'November'
            break
        case 12:
            result = 'December'
            break
        default:
            result = 'Error!'
            break
    }

    console.log(result)
}

solve(12)

//05. Math Operations

function solve(a, b, operator){
    let result;

    if (operator === '+'){
        result = a + b;
    } else if (operator === '-'){
        result = a - b;
    } else if (operator === '*'){
        result = a * b;
    } else if (operator === '/'){
        result = a / b;
    } else if (operator === '%'){
        result = a % b;
    } else if (operator === '**'){
        result = a ** b;
    }

    console.log(result)
}

solve(5, 5, '+')
solve(5, 5, '-')
solve(5, 5, '*')
solve(5, 5, '/')
solve(7, 5, '%')
solve(5, 3, '**')

//06. Largest Number

function solve(a, b, c){
    let maxNumber = Number.MIN_SAFE_INTEGER;

    if(a > maxNumber){
        maxNumber = a;
    }

    if(b > maxNumber){
        maxNumber = b;
    }

    if(c > maxNumber){
        maxNumber = c;
    }

    console.log(`The largest number is ${maxNumber}.`)
}

solve(3, -5, 12)
solve(13, 5, 12)
solve(-3, -5, -12)


//07. Theatre Promotions

function solve(tariff, clientAge) {
    
    let price = 0;

    if (0 <= clientAge && clientAge <= 18) {
        switch(tariff) {
            case "Weekday": 
                price = 12;
                break;
                case "Weekend":
                price = 15;
                break;
            case "Holiday":
                price = 5;
                break;
        }
    } else if (18 < clientAge && clientAge <=64) {
        switch(tariff) {
            case "Weekday": 
                price = 18;
                break;
            case "Weekend":
                price = 20;
                break;
            case "Holiday":
                price = 12;
                break;
        }
    } else if (64 < clientAge && clientAge <=122) {
        switch(tariff) {
            case "Weekday": 
                price = 12;
                break;
            case "Weekend":
                price = 15;
                break;
            case "Holiday":
                price = 10;
                break;
            }
    } else {
        console.log("Error!");
    }

    if (price > 0) {
        console.log(`${price}$`);
    }
}

//08. Circle Area

function solve(input){

    if(typeof input === 'number'){
        let area = Math.pow(input, 2) * Math.PI;

        console.log(area.toFixed(2))
    } else {
        console.log(`We can not calculate the circle area, because we received a ${typeof input}.`)
    }

}

solve(5)
solve('pet')

//09. Numbers from 1 to 5

function solve()
{
    for (i = 1 ; i <=5 ; i++)
    {
        console.log(i);
    }
}

//10. Numbers from M to N

function solve(m, n) {
    for (let i = m; i >= n; i--) {
        console.log(i);
    }
}