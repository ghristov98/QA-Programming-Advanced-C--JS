function addAndSubtract(numbers) {
 

    let sum = 0; 
    let modifiedSum = 0; 
    
    for (let position = 0; position <= numbers.length - 1; position++) {
            sum += numbers[position];

            
            if (numbers[position] % 2 === 0) {
                numbers[position] += position;
            } else {
                numbers[position] -= position;
            }

            
            modifiedSum += numbers[position];
    }

    console.log(numbers);
    console.log(sum);
    console.log(modifiedSum);
}

addAndSubtract([5, 15, 23, 56, 35]);