import {sum} from '../sumOfNumbers.js'
import { expect } from 'chai'

describe('Test function sum', () => {
    it('shoud return correct sum if array with numbers is passed', () => {
        // arrange
        let inputArr = [1, 2, 3, 4]
        let expected = 10

        // act
        let result = sum(inputArr)

        //assert
        expect(result).to.equal(expected)
    }), 
    it('shoud return same number if the array have one element', () => {
         // arrange
        let inputArr = [42]
        let expected = 42

        // act
        let result = sum(inputArr)

        //assert
        expect(result).to.equal(expected)
    }),
    it('shour return zero if input arrays is empty', () => {
        // arrange
        let inputArr = []
        let expected = 0

        // act
        let result = sum(inputArr)

        //assert
        expect(result).to.equal(expected)
    })
})