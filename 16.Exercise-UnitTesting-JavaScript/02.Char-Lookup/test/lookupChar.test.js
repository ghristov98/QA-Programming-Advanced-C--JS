import { lookupChar } from '../lookupChar.js'
import { describe } from 'mocha'
import { expect } from 'chai'

describe('Test lookupChar', () => {
    it('shoud return undefined if first input parameters is not a string', () => {
        expect(lookupChar(42, 2)).to.be.undefined
        expect(lookupChar([5], 2)).to.be.undefined
        expect(lookupChar({}, 2)).to.be.undefined
        expect(lookupChar(null, 2)).to.be.undefined
        expect(lookupChar(undefined, 2)).to.be.undefined
    }),
    it('shoud return undefined if second input parameters is not integer', () => {
        expect(lookupChar('Hello', [2])).to.be.undefined
        expect(lookupChar('Hello', 3.5)).to.be.undefined
        expect(lookupChar('Hello', '2')).to.be.undefined
        expect(lookupChar('Hello', {})).to.be.undefined
        expect(lookupChar('Hello', null)).to.be.undefined
        expect(lookupChar('Hello', undefined)).to.be.undefined
    }),
    it('shoud return "Incorrect index" if index is out of input string range', () => {
        expect(lookupChar('Hello', -5)).to.equal('Incorrect index')
        expect(lookupChar('Hello', -1)).to.equal('Incorrect index')
        expect(lookupChar('Hello', 5)).to.equal('Incorrect index')
        expect(lookupChar('Hello', 10)).to.equal('Incorrect index')
    }),
    it('shoud return correct char if input parameters are valid', () => {
        expect(lookupChar('Hello', 0)).to.equal('H')
        expect(lookupChar('Hello', 1)).to.equal('e')
        expect(lookupChar('Hello', 4)).to.equal('o')
    })
})