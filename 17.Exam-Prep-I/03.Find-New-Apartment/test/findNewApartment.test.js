import { findNewApartment } from '../findNewApartment.js'
import { describe } from 'mocha'
import { expect, assert } from 'chai'

describe('test_findNewApartment', () =>{
    describe('isGoodLocation', () => {
        it('should throw error on invalid input', () => {
            assert.throws(() => findNewApartment.isGoodLocation(['Sofia'], false), 'Invalid input');
            assert.throws(() => findNewApartment.isGoodLocation(['Sofia'], 1), 'Invalid input');
            assert.throws(() => findNewApartment.isGoodLocation(['Sofia'], null), 'Invalid input');
            assert.throws(() => findNewApartment.isGoodLocation(['Sofia'], undefined), 'Invalid input');
        });
        it('should return "This location is not suitable for you." if location is not valid', () => {
            //Arrange
            const result = findNewApartment.isGoodLocation(['Ruse'], true);
            //Act
            const expected = "This location is not suitable for you.";
            //Assert
            assert.equal(result, expected);
        });
        it('should return "You can go on home tour!" if location is good and public transport is available', () => {
            //Arrange
            const city = 'Sofia';
            const nearPublicTransportation = true;
            const expected = "You can go on home tour!";
            // Act
            const result = findNewApartment.isGoodLocation(city, nearPublicTransportation);
            // Assert
            assert.equal(result, expected);
        });
        it('should return "There is no public transport in area." if location is good but public transport is unavailable', () => {
            // Arrange
            const city = 'Sofia';
            const nearPublicTransportation = false;
            const expected = "There is no public transport in area.";
            // Act
            const result = findNewApartment.isGoodLocation(city, nearPublicTransportation);
            // Assert
            assert.equal(result, expected);
        });
    }),
    describe('Test isLargeEnough', () => {
        it('Should return apartments that meet the wanted criteria for minimal square meters', () => {
            // Arrange
            const apartments = [50, 75, 100, 120];
            const minimalSquareMeters = 75;
            const expected = [75, 100, 120];
            // Act
            const result = findNewApartment.isLargeEnough(apartments, minimalSquareMeters);
            // Assert
            assert.equal(result, expected);
        });

        it('Should throw error on invalid input', () => {
            assert.throws(() => findNewApartment.isLargeEnough('75 100 120', 100), 'Invalid input');
            assert.throws(() => findNewApartment.isLargeEnough([75, 100, 120], '100'), 'Invalid input');
            assert.throws(() => findNewApartment.isLargeEnough([75, 100, 120], -100), 'Invalid input');
            assert.throws(() => findNewApartment.isLargeEnough([75, 100, 120], 0), 'Invalid input');
            assert.throws(() => findNewApartment.isLargeEnough([], 100), 'Invalid input');
        });
    }),
    describe('isItAffordable', () => {
        it('should throw an error on invalid input', () => {
            assert.throws(() => findNewApartment.isItAffordable('200', 1000), 'Invalid input');
            assert.throws(() => findNewApartment.isItAffordable(200, -100), 'Invalid input');
            assert.throws(() => findNewApartment.isItAffordable(200, 0), 'Invalid input');
            assert.throws(() => findNewApartment.isItAffordable(0, 200), 'Invalid input');
            assert.throws(() => findNewApartment.isItAffordable(200, '1000'), 'Invalid input');
            assert.throws(() => findNewApartment.isItAffordable('200', '1000'), 'Invalid input');
            assert.throws(() => findNewApartment.isItAffordable(-1, 1000), 'Invalid input');
        });
        it('should not be affordable if price is greater than budget', () => {
            // Arrange
            const price = 1300;
            const budget = 1000;
            const expected = "You don't have enough money for this house!";
            // Act
            const result = findNewApartment.isItAffordable(price, budget);
            // Assert
            assert.isFalse(result);
        });
        it('should be affordable if price is equal to or less than budget', () => {
            // Arrange
            const price = 800;
            const budget = 1000;
            const expected = "This house is affordable!";
            // Act
            const result = findNewApartment.isItAffordable(price, budget);
            // Assert
            assert.isTrue(result);
        });
    })
})


