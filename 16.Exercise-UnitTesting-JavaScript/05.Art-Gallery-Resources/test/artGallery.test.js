import { artGallery } from '../artGallery.js'
import { describe } from 'mocha'
import { expect } from 'chai'

describe('Test artGallery', () => {
    describe('addArtwork', () => {
        it('shoud throw an error "Invalid Information!" if title is not a string', () => {
            expect(() => artGallery.addArtwork(42, '50 x 70', 'Picasso')).to.throw("Invalid Information!")
            expect(() => artGallery.addArtwork(['title'], '50 x 70', 'Picasso')).to.throw("Invalid Information!")
            expect(() => artGallery.addArtwork({}, '50 x 70', 'Picasso')).to.throw("Invalid Information!")
            expect(() => artGallery.addArtwork(null, '50 x 70', 'Picasso')).to.throw("Invalid Information!")
            expect(() => artGallery.addArtwork(undefined, '50 x 70', 'Picasso')).to.throw("Invalid Information!")
            
        }),
        it('shoud throw an error "Invalid Information!" if artist is not a string', () => {
            expect(() => artGallery.addArtwork('Guernica', '50 x 70', 42)).to.throw("Invalid Information!")
            expect(() => artGallery.addArtwork('Guernica', '50 x 70', ['name'])).to.throw("Invalid Information!")
            expect(() => artGallery.addArtwork('Guernica', '50 x 70', {})).to.throw("Invalid Information!")
            expect(() => artGallery.addArtwork('Guernica', '50 x 70', null)).to.throw("Invalid Information!")
            expect(() => artGallery.addArtwork('Guernica', '50 x 70', undefined)).to.throw("Invalid Information!")
            
        }),
        it('shoud throw an error "Invalid Dimensions!" if dimension is not a valid format', () => {
            expect(() => artGallery.addArtwork('Guernica', 42, 'Picasso')).to.throw("Invalid Dimensions!")
            expect(() => artGallery.addArtwork('Guernica', '40x50', 'Picasso')).to.throw("Invalid Dimensions!")
            expect(() => artGallery.addArtwork('Guernica', 'a40 x 50', 'Picasso')).to.throw("Invalid Dimensions!")
            expect(() => artGallery.addArtwork('Guernica', '40x 50', 'Picasso')).to.throw("Invalid Dimensions!")
            expect(() => artGallery.addArtwork('Guernica', '40 x50', 'Picasso')).to.throw("Invalid Dimensions!")
            expect(() => artGallery.addArtwork('Guernica', null, 'Picasso')).to.throw("Invalid Dimensions!")
            expect(() => artGallery.addArtwork('Guernica', undefined, 'Picasso')).to.throw("Invalid Dimensions!")
        })
        it('shoud throw an error if artist is not from gallery artwork', () => {
            expect(() => artGallery.addArtwork('Guernica', '50 x 70', 'Vladimir Dimitrov - Maystora')).to.throw("This artist is not allowed in the gallery!")
        }),
        it('shoud return proper message if all parameters are valid', () => {
            let expected = `Artwork added successfully: 'Guernica' by Picasso with dimensions 50 x 70.`

            expect(artGallery.addArtwork('Guernica', '50 x 70', 'Picasso')).to.equal(expected)
        })
    }),
    describe('calculateCosts', () => {
        it('shoud throw an error if input parameter is not valid', () => {
            expect(() => artGallery.calculateCosts('42', 100, true)).to.throw("Invalid Information!")
            expect(() => artGallery.calculateCosts(200, 'abc', true)).to.throw("Invalid Information!")
            expect(() => artGallery.calculateCosts(200, 100, 'abc')).to.throw("Invalid Information!")
            expect(() => artGallery.calculateCosts(-10, 100, true)).to.throw("Invalid Information!")
            expect(() => artGallery.calculateCosts(200, -10, true)).to.throw("Invalid Information!")
        }),
        it('shoud return a proper message if sponsor is true', () => {
            let expected = `Exhibition and insurance costs are 270$, reduced by 10% with the help of a donation from your sponsor.`
            expect(artGallery.calculateCosts(100, 200, true)).to.equal(expected)
        }),
        it('shoud return a proper message if sponsor is false', () => {
            let expected = `Exhibition and insurance costs are 300$.`
            expect(artGallery.calculateCosts(100, 200, false)).to.equal(expected)
        })
    }),
    describe('organizeExhibits', () => {
        it('shoud throw an error if input parameter is not valid', () => {
            // validate first parameter
            expect(() => artGallery.organizeExhibits('abc', 100)).to.throw("Invalid Information!")
            expect(() => artGallery.organizeExhibits(-10, 100)).to.throw("Invalid Information!")
            // validate second parameter
            expect(() => artGallery.organizeExhibits(10, 'abc')).to.throw("Invalid Information!")
            expect(() => artGallery.organizeExhibits(10, -10)).to.throw("Invalid Information!")
        }),
        it('shour return proper message if artworksPerSpace is less than 5', () => {
            let expected = `There are only 4 artworks in each display space, you can add more artworks.`
            expect(artGallery.organizeExhibits(100, 22)).to.equal(expected)
        }),
        it('shour return proper message if artworksPerSpace is greater than 5', () => {
            let expected = `You have 15 display spaces with 6 artworks in each space.`
            expect(artGallery.organizeExhibits(100, 15)).to.equal(expected)
        }),
         it('shour return proper message if artworksPerSpace is equal to 5', () => {
            let expected = `You have 18 display spaces with 5 artworks in each space.`
            expect(artGallery.organizeExhibits(100, 18)).to.equal(expected)
        })
    })
})