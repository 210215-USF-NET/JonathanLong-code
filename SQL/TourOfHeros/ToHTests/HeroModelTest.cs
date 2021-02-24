
using System;
using Xunit;
using ToHModels;
//Note that models aren't really suppose to be unit tested bc they mainly hold data 
//You should focus on unit testing logic like your business logic or data layer logic
//Also, dobn't unit test your UI
namespace ToHTests
{
    public class HeroModelTest
    {
        //3 parts of a unit test 
            //arrange - all about setting up the things you need for the unit test 
            //act - doing the thing you want to test 
            //assert - comparing the actual results to the expected outcome 


        private Hero testHero = new Hero();

        [Fact] //this is a fact attribute - takes no unit arguments - tests which are always true and test in variant conditions 
        public void HeroNameShouldBeSet()
        {
            string testName = "the tick";
            //Act
            testHero.HeroName = testName;
            //Assert
            AssemblyLoadEventArgs.Equals(testName, testHero.HeroName);
            
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]

        public void HeroNameShouldNotBeEmpty(string testName)
        {
            //Act and Assert 
            Assert.Throws<ArgumentNullException>(() => testHero.HeroName = testName);
        }

    }
}
