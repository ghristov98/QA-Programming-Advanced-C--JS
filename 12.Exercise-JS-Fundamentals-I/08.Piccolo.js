function piccolo (array) {

    let parking = []; 

    for (let command of array) {
        let action = command.split(', ')[0]; 
        let carNumber = command.split(', ')[1];

        if (action === 'IN') {
            if (!parking.includes(carNumber)){
                parking.push(carNumber);
            }
        } else if (action === 'OUT') {
            let position = parking.indexOf(carNumber);
            if (position !== -1) {
                parking.splice(position, 1);
            }
        }
    }

    parking.sort(); 

    if (parking.length === 0) {
        console.log('Parking Lot is Empty')
    } else {
        for (let carNumber of parking) {
            console.log(carNumber);
        }
    }
}

piccolo(['IN, CA2844AA',
'IN, CA1234TA',
'OUT, CA2844AA',
'IN, CA9999TT',
'IN, CA2866HI',
'OUT, CA1234TA',
'IN, CA2844AA',
'OUT, CA2866HI',
'IN, CA9876HH',
'IN, CA2822UU']
);