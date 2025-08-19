import { rgbToHexColor } from '../RGBToHex.js'
import { expect } from 'chai'

describe('Test rgbToHexColor function', () => {
    it('shoud return undefined if any of parameters is not valid', () => {
        expect(rgbToHexColor(-1, 0, 0)).to.be.undefined
        expect(rgbToHexColor(256, 0, 0)).to.be.undefined
        expect(rgbToHexColor('a', 0, 0)).to.be.undefined

        expect(rgbToHexColor(0, -1, 0)).to.be.undefined
        expect(rgbToHexColor(0, 256, 0)).to.be.undefined
        expect(rgbToHexColor(0, [], 0)).to.be.undefined

        expect(rgbToHexColor(0, 0, -5)).to.be.undefined
        expect(rgbToHexColor(0, 0, 260)).to.be.undefined
        expect(rgbToHexColor(0, 0, {})).to.be.undefined
    }),
    it('shoud return hexademical code if input parameters are valid', () => {
        expect(rgbToHexColor(0,0,0)).to.equal('#000000') // black
        expect(rgbToHexColor(255,255,255)).to.equal('#FFFFFF') // white
        expect(rgbToHexColor(123,50,200)).to.equal('#7B32C8') // purple
    })
})