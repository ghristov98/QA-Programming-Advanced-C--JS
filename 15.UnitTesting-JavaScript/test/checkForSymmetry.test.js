import { expect } from "chai";
import {isSymmetric} from '../checkForSymmetry.js'

describe('Test isSymetric', () => {
    it('shoud return false if input is not an array', () => {       
        expect(isSymmetric(1)).to.be.false
        expect(isSymmetric(1, 2, 3)).to.be.false
        expect(isSymmetric("hello")).to.be.false
    }),
    it('shoud return true if input array is symetric', () => {
        expect(isSymmetric([1, 2, 1])).to.be.true
        expect(isSymmetric(['hi', 'hello', 'hi'])).to.be.true
        expect(isSymmetric(['1', 2, 2, '1'])).to.be.true
        expect(isSymmetric(['a', '2', '2', 'a'])).to.be.true
        expect(isSymmetric(['a', [1], [1], 'a'])).to.be.true
    }),
    it('shoud return false if input array is not symetric', () => {
        expect(isSymmetric([1, 2, 3])).to.be.false
        expect(isSymmetric(['hi', 'hello', 'hi', 'hello'])).to.be.false
        expect(isSymmetric(['1', 2, '2', 1])).to.be.false
        expect(isSymmetric(['a', '2', '2', 'a'])).to.be.true
        expect(isSymmetric(['a', [1], 'c', 5])).to.be.false
    })
})