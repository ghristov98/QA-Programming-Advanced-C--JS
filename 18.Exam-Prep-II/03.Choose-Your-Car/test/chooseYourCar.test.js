import { chooseYourCar } from '../chooseYourCar.js'
import { describe } from 'mocha'
import { expect, assert } from 'chai';

describe('Test chooseYourCar', () => {
    describe('choosingType', () => {
        it('should throw an error on invalid input', () => {
            //invalid input -> невалидна година и невалиден вид кола
            //невалидна година: година < 1900 или година > 2022
            expect(() => chooseYourCar.choosingType("Sedan", "red", 1800)).to.throw(Error, 'Invalid Year!');
            expect(() => chooseYourCar.choosingType("Sedan", "black", 2024)).to.throw(Error, 'Invalid Year!');

            //невалиден вид кола: вид различен от Седан
            expect(() => chooseYourCar.choosingType("Truck", "blue", 2007)).to.throw(Error, 'This type of car is not what you are looking for.');
        });
        it('should meet requirments for a car', () => {
            //Arrange
            const type = "Sedan";
            const year = 2015;
            const color = "black";
            const expected = 'This black Sedan meets the requirements, that you have.';

            //Act
            const result = chooseYourCar.choosingType(type, color, year);

            //Assert
            expect(result).to.equal(expected);
        });
        it('should not meet requirments for a car', () => {
            //Arrange
            const type = "Sedan";
            const color = "blue";
            const year = 2007;
            const expected = "This Sedan is too old for you, especially with that blue color.";

            //Act
            const result = chooseYourCar.choosingType(type, color, year);

            //Assert
            expect(result).to.equal(expected);
        });
    });

    describe('brandName', () => {
        it('should throw an error on invalid input', () => {
            //invalid input
            //1. brands да не е масив
            expect(() => chooseYourCar.brandName("Audi", 3)).to.throw(Error, "Invalid Information!");
            //2. brandIndex не е цяло число
             expect(() => chooseYourCar.brandName(["Audi", "BMW"], 3.5)).to.throw(Error, "Invalid Information!");
            //3. brandIndex е цяло число < 0
            expect(() => chooseYourCar.brandName(["Audi", "BMW"], -1)).to.throw(Error, "Invalid Information!");
            //4. brandIndex е цяло число >= дължина на масив
             expect(() => chooseYourCar.brandName(["Audi", "BMW"], 5)).to.throw(Error, "Invalid Information!");
             //5. brands да не е масив и brandIndex не е валиден
             expect(() => chooseYourCar.brandName(123, 0)).to.throw(Error, "Invalid Information!");
        });

        it('should return the correct brands', () => {
            //Arrange
            const brands = ["Audi", "BMW", "Mercedes"];
            const brandIndex = 1;
            const expected = "Audi, Mercedes";

            //Act
            const result = chooseYourCar.brandName(brands, brandIndex);

            //Assert
            expect(result).to.equal(expected);
        });
    });

    describe('carFuelConsumption', () => {
        it('should throw an error on invalid input', () => {
            //invalid input
            //1. разстоянието да не е число
            expect(() => chooseYourCar.carFuelConsumption("distance", 12)).to.throw(Error, "Invalid Information!");
            //2. разстоянието е число <= 0
            expect(() => chooseYourCar.carFuelConsumption(-10, 12)).to.throw(Error, "Invalid Information!");
            //3. литрите не са число
            expect(() => chooseYourCar.carFuelConsumption(100, "liters")).to.throw(Error, "Invalid Information!");
            //4. литрите са число <= 0
            expect(() => chooseYourCar.carFuelConsumption(100, -10)).to.throw(Error, "Invalid Information!");
        });

        it('should return message for an efficient car', () => {
            //Arrange
            const liters = 5;
            const distance = 100;
            const expected = "The car is efficient enough, it burns 5.50 liters/100 km."

            //Act
            const result = chooseYourCar.carFuelConsumption(distance, liters);

            //Assert
            expect(result).to.equal(expected);
        });

        it('should return message for an non efficient car', () => {
            //Arrange
            const liters = 10;
            const distance = 100;
            const expected = "The car burns too much fuel - 10.50 liters!";

            //Act
            const result = chooseYourCar.carFuelConsumption(distance, liters);

            //Assert
            expect(result).to.equal(expected);
        });
    });
});