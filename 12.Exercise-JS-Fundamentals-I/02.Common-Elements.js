function commonElements (arr1, arr2) {


    for (let element of arr1) {
        if (arr2.includes(element)) {
            console.log(element);
        }  
    }

}

commonElements(['S', 'o', 'f', 't', 'U', 'n', 'i', ' '], ['s', 'o', 'c', 'i', 'a', 'l']);