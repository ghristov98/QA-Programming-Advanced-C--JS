function arrayRotation (arr, countRotations) {
    

    for (let rotations = 1; rotations <= countRotations; rotations++) {
        let firstElement = arr.shift(); 
        arr.push(firstElement); 
    }

    console.log(arr.join(' '));
}
arrayRotation([51, 47, 32, 61, 21], 2);