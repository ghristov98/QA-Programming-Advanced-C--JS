import {isOddOrEven} from '../isOddOrEven.js'
import { describe } from 'mocha'
import { expect } from 'chai'

describe('Test isOddOrEven', () => {
    it('shoud return undefined is input parameter is not a string', () => {
        //let result = isOddOrEven(42)
        expect(isOddOrEven(42)).to.be.undefined
        expect(isOddOrEven([5])).to.be.undefined
        expect(isOddOrEven({})).to.be.undefined
        expect(isOddOrEven(null)).to.be.undefined
    }),
    it('shoud return even if input length is with even count of characters', () => {
        let expected = 'even'

        let actual = isOddOrEven('Hello!')

        expect(actual).to.equal(expected)
    }),
    it('shoud return odd if input length is with odd count of characters', () => {
        let expected = 'odd'

        let actual = isOddOrEven('Diyan')

        expect(actual).to.equal(expected)
    })
})