function maxNumber (numbers) {
    let topNumbers = []; 

    for (let position = 0; position < numbers.length - 1; position++) {
        let number = numbers[position];
        let isTop = true; 

        for (let rightPosition = position + 1; rightPosition <= numbers.length - 1; rightPosition++) {
            let numberInRight = numbers[rightPosition];
            if (number <= numberInRight) {
                isTop = false;
                break;
            }
        }
      
        if (isTop) {
            topNumbers.push(number);
        }
    }

    topNumbers.push(numbers[numbers.length - 1]);

    console.log(topNumbers.join(' '));
}

maxNumber([14, 24, 3, 19, 15, 17]);