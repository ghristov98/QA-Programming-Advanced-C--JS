import { createCalculator } from '../addSubtract.js'
import { expect } from 'chai'

describe('Test createCalculator', () => {
    let calculator;

    beforeEach(() => {
        calculator = createCalculator()
    })

    it('shoud add number correctly if input is a number', () => {
        calculator.add(7)
        expect(calculator.get()).to.equal(7)
    }),
    it('shoud add number correctly if input is a string', () => {
        calculator.add("5")
        calculator.add(7)
        expect(calculator.get()).to.equal(12)
    }),
    it('shoud subtract number correctly if input is a number', () => {
        calculator.subtract(5)
        expect(calculator.get()).to.equal(-5)
    }),
    it('shoud subtract number correctly if input is a string', () => {
        calculator.subtract('2')
        expect(calculator.get()).to.equal(-2)
    }),
    it('shoud return zero if object is just declare', () => {
        expect(calculator.get()).to.equal(0)
    }),
    it('shoud not modify value directly from outside', () => {
        expect(calculator.value).to.be.undefined
    })
})