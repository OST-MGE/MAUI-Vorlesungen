// ReSharper disable StringLiteralTypo
// ReSharper disable ConvertToLocalFunction
// ReSharper disable ConvertToLambdaExpression
// ReSharper disable CommentTypo

using Xunit.Abstractions;

namespace Refresher_CSharp
{
    using System;
    using FluentAssertions;
    using Xunit;

    public class Tests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Tests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Properties()
        {
            var person = new Person
            {
                FirstName = "Thomas",
                LastName = "Kälin"
            };

            person.FirstName.Should().Be("Thomas");
            person.LastName.Should().Be("Kälin");
            person.FullName.Should().Be("Kälin Thomas");
            person.FullNameInv.Should().Be("Thomas Kälin");
        }

        [Fact]
        public void Delegates()
        {
            const int x = 2;
            const int y = 3;

            Calculator.Add(x, y).Should().Be(5);
            Calculator.Multiply(x, y).Should().Be(6);

            Calculator.Calculation add = Calculator.Add;
            Calculator.Calculation subtract1 = delegate(int a, int b) { return a - b; };
            Calculator.Calculation subtract2 = (a, b) => a - b;

            add(x, y).Should().Be(5);
            subtract1(x, y).Should().Be(-1);
            subtract2(x, y).Should().Be(-1);
        }

        [Fact]
        public void Action_And_Func_And_Lambdas()
        {
            Func<int, int, int> add = Calculator.Add;
            Func<int, int, int> subtract1 = delegate (int a, int b) { return a - b; };
            Func<int, int, int> subtract2 = (a, b) => a - b;

            Action<int, int> addAndSubtract = (a, b) =>
            {
                // Closure: Zugriff auf add, subtract1 und subtract2 m�glich
                add(a, b).Should().Be(a + b);
                subtract1(a, b).Should().Be(a - b);
                subtract2(a, b).Should().Be(a - b);
            };

            addAndSubtract(2, 3);
        }

        [Fact]
        public void Events()
        {
            var person = new Person();

            EventHandler<string> onNickNameChanged = (_, name) =>
            {
                _testOutputHelper.WriteLine(name);
            };

            person.NickNameChanged += onNickNameChanged;
            person.NickNameChanged += onNickNameChanged;
            person.NickName = "N00b";

            person.NickNameChanged -= onNickNameChanged;
            person.NickName = "Advanc3d";

            person.NickNameChanged -= onNickNameChanged;
            person.NickName = "Pr0";
        }
    }
}