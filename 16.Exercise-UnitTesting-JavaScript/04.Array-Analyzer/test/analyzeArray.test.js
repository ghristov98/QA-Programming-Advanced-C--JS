import { analyzeArray } from '../analyzeArray.js'
import { expect } from 'chai';

describe('Test_arrayAnalyzer', () => {
    it('shoud return object with properties(min, max, length) if array is an array of numbers with different values)', () => {
        let expectedObj = {
            min: 1,
            max: 17,
            lenght: 5
        }

        expect(analyzeArray([1, 17, 4, 8, 3]).min).to.equal(expectedObj.min)
        expect(analyzeArray([1, 17, 4, 8, 3]).max).to.equal(expectedObj.max)
        expect(analyzeArray([1, 17, 4, 8, 3]).length).to.equal(expectedObj.lenght)
    });

    it('shoud return object with properties(min, max, length) if array is an array of numbers with equal values)', () => {
        let expectedObj = {
            min: 42,
            max: 42,
            lenght: 5
        }

         expect(analyzeArray([42, 42, 42, 42, 42]).min).to.equal(expectedObj.min)
         expect(analyzeArray([42, 42, 42, 42, 42]).max).to.equal(expectedObj.max)
         expect(analyzeArray([42, 42, 42, 42, 42]).length).to.equal(expectedObj.lenght)
    });

    it('shoud return object with properties(min, max, length) if array is an array of sinbgle element)', () => {
        let expectedObj = {
            min: 42,
            max: 42,
            lenght: 1
        }

         expect(analyzeArray([42]).min).to.equal(expectedObj.min)
         expect(analyzeArray([42]).max).to.equal(expectedObj.max)
         expect(analyzeArray([42]).length).to.equal(expectedObj.lenght)
    });

    it('shoud return undefined if input array is empty', () => {
        expect(analyzeArray([])).to.undefined
    });
    
    it('shoud return undefined if input array is not an array', () => {
        expect(analyzeArray('hello')).to.undefined
        expect(analyzeArray('a')).to.undefined
        expect(analyzeArray(5)).to.undefined
        expect(analyzeArray(null)).to.undefined
        expect(analyzeArray(undefined)).to.undefined
    });

    //this test is not from problem description - testing row 10 in arrayAnalyzer.js file
    it('shoud return undefined if some of element in the array is not a number', () => {
        expect(analyzeArray([4, 7, 'a', 10])).to.undefined
    });
});