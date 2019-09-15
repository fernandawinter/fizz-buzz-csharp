using FizzBuzz;
using System;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzExecuterTest
    {
        [Fact]
        public void Test1()
        {
            FizzBuzzExecuter executer = new FizzBuzzExecuter();
            string result = executer.Execute(1);
            Assert.Equal("1", result);
        }


        [Fact]
        public void Test2()
        {
            FizzBuzzExecuter executer = new FizzBuzzExecuter();
            string result = executer.Execute(2);
            Assert.Equal("2", result);
        }



        [Fact]
        public void Test3()
        {
            FizzBuzzExecuter executer = new FizzBuzzExecuter();
            string result = executer.Execute(3);
            Assert.Equal("fizz", result);
        }

        [Fact]
        public void Test5()
        {
            FizzBuzzExecuter executer = new FizzBuzzExecuter();
            string result = executer.Execute(5);
            Assert.Equal("buzz", result);
        }

        [Fact]
        public void Test15()
        {
            FizzBuzzExecuter executer = new FizzBuzzExecuter();
            string result = executer.Execute(15);
            Assert.Equal("fizzbuzz", result);
        }

        [Fact]
        public void Test9()
        {
            FizzBuzzExecuter executer = new FizzBuzzExecuter();
            string result = executer.Execute(9);
            Assert.Equal("fizz", result);
        }
    }
}
