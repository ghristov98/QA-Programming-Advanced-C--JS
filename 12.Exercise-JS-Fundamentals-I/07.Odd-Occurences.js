    function oddOccurences (sentence) {
    let words = sentence.toLowerCase().split(' ');
   
    let wordsCount = {};
    for (let word of words) {
        if (wordsCount[word]) {
            wordsCount[word]++;
        } else {
            wordsCount[word] = 1;
        }
    }

    
    let oddOccurencesWords = []; 
    for (let word in wordsCount) {
        if (wordsCount[word] % 2 !== 0) {
            oddOccurencesWords.push(word);
        }
    }

    console.log(oddOccurencesWords.join(' '));
} 

oddOccurences('Cake IS SWEET is Soft CAKE sweet Food');