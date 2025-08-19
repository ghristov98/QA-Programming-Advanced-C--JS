import { foodDelivery } from '../foodDelivery.js'
import { describe } from 'mocha'
import { expect } from 'chai'

describe('Test foodDelivery', () => {
    describe('getCategory', () => {
        it('shoud return proper message for input Vegan', () => {
            expect(foodDelivery.getCategory('Vegan')).to.equal('Dishes that contain no animal products.')
        }),
        it('shoud return proper message for input Vegetarian', () => {
            expect(foodDelivery.getCategory('Vegetarian')).to.equal('Dishes that contain no meat or fish.')
        }),
        it('shoud return proper message for input Gluten-Free', () => {
            expect(foodDelivery.getCategory('Gluten-Free')).to.equal('Dishes that contain no gluten.')
        }),
        it('shoud return proper message for input All', () => {
            expect(foodDelivery.getCategory('All')).to.equal('All available dishes.')
        }),
        it('shoud throw an error if input parameter is not valid', () => {
            expect(() => foodDelivery.getCategory('invalid category')).to.throw("Invalid Category!")
        })
        // to check type
    }), 
    describe('addMenuItem', () => {
        it('shoud throw an error if input parameters are not valid', () => {
            let validMenuItem = [
                {name: 'Item1', price: 10},
                {name: 'Item2', price: 10},
                {name: 'Item3', price: 10}
            ]
            // invalid first parameter
            expect(() => foodDelivery.addMenuItem(validMenuItem, 'abc')).to.throw("Invalid Information!")
            expect(() => foodDelivery.addMenuItem(validMenuItem, 4)).to.throw("Invalid Information!")
            // invalid second parameter
            expect(() => foodDelivery.addMenuItem('not array', 100)).to.throw("Invalid Information!")
            expect(() => foodDelivery.addMenuItem([], 100)).to.throw("Invalid Information!")
        }),
        it('shoud return proper message if parameters are valid', () => {
            let menuItem = [
                {name: 'Item1', price: 10},
                {name: 'Item2', price: 50},
                {name: 'Item3', price: 30},
                {name: 'Item4', price: 35}
            ]

            let expected = `There are 3 available menu items matching your criteria!`;

            expect(foodDelivery.addMenuItem(menuItem, 40)).to.equal(expected)
        }),
        it('shoud return proper message if all items prices are gteater than maxPrice', () => {
            let menuItem = [
                {name: 'Item1', price: 10},
                {name: 'Item2', price: 50},
                {name: 'Item3', price: 30},
                {name: 'Item4', price: 35}
            ]

            let expected = `There are 0 available menu items matching your criteria!`;

            expect(foodDelivery.addMenuItem(menuItem, 7)).to.equal(expected)
        })
    }), 
    describe('calculateOrderCost', () => {
        it('shoud throw an error if input parameters are not valid', () => {
            // validate first parameter
            expect(() => foodDelivery.calculateOrderCost('abc', [], true)).to.throw("Invalid Information!")
            // validate second parameter
            expect(() => foodDelivery.calculateOrderCost([], 'def', true)).to.throw("Invalid Information!")
            // validate third parameter
            expect(() => foodDelivery.calculateOrderCost([], [], 'xyz')).to.throw("Invalid Information!")
        }),
        it('shoud return proper message if discount is true', () => {
            let expected = 'You spend $13.17 for shipping and addons with a 15% discount!'
            let shippingArray = ['standard', 'express', 'standard']
            let addonsArray = ['beverage', 'sauce']

            expect(foodDelivery.calculateOrderCost(shippingArray, addonsArray, true)).to.equal(expected)
        }),
        it('shoud return proper message if discount is false', () => {
            let expected = 'You spend $15.50 for shipping and addons!'
            let shippingArray = ['standard', 'express', 'standard']
            let addonsArray = ['beverage', 'sauce']

            expect(foodDelivery.calculateOrderCost(shippingArray, addonsArray, false)).to.equal(expected)
        })
    })
})