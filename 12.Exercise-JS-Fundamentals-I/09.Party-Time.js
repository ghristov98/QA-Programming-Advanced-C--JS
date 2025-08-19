function arrayManipulations(inputArr) {
    let guestList = [];

    while (inputArr[0] !== 'PARTY') {
        guestList.push(inputArr.shift());
    }

    inputArr.shift(); 

    for (let guest of inputArr) {
        let index = guestList.indexOf(guest);
        if (index !== -1) {
            guestList.splice(index, 1); 
        }
    }

    let vipGuests = guestList.filter(guest => !isNaN(guest[0]));
    let regularGuests = guestList.filter(guest => isNaN(guest[0]));

    console.log(guestList.length);
    console.log(vipGuests.join('\n'));
    console.log(regularGuests.join('\n'));
}