using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050
{
    public class _020_Valid_Parentheses_Test
    {

        [Test]
        public void Valid_Parentheses_Empty_Parentheses()
        {
            string s = "";
            var solution = new _020_Valid_Parentheses();
            var result = solution.IsValid(s);

            Assert.That(result, Is.False);

        }

        [Test]
        public void Valid_Parentheses_One_Parentheses_True()
        {
            string s = "()";
            var solution = new _020_Valid_Parentheses();
            var result = solution.IsValid(s);

            Assert.That(result, Is.True);

        }

        [Test]
        public void Valid_Parentheses_Two_Parentheses_True()
        {
            string s = "({})";
            var solution = new _020_Valid_Parentheses();
            var result = solution.IsValid(s);

            Assert.That(result, Is.True);

        }

        [Test]
        public void Valid_Parentheses_Two_Parentheses_And_AnyChar_True()
        {
            string s = "[Bo(o)M]";
            var solution = new _020_Valid_Parentheses();
            var result = solution.IsValid(s);

            Assert.That(result, Is.True);

        }


        [Test]
        public void Valid_Parentheses_Three_Parentheses_True()
        {
            string s = "()[]{}";
            var solution = new _020_Valid_Parentheses();
            var result = solution.IsValid(s);

            Assert.That(result, Is.True);

        }


        [Test]
        public void Valid_Parentheses_One_Parentheses_False()
        {
            string s = "(]";
            var solution = new _020_Valid_Parentheses();
            var result = solution.IsValid(s);

            Assert.That(result, Is.False);

        }

        [Test]
        public void Valid_Parentheses_Two_Parentheses_False()
        {
            string s = "([)]";
            var solution = new _020_Valid_Parentheses();
            var result = solution.IsValid(s);

            Assert.That(result, Is.False);

        }

        [Test]
        public void Valid_Parentheses_Three_Parentheses_False()
        {
            string s = "[B{o}(o]M)";
            var solution = new _020_Valid_Parentheses();
            var result = solution.IsValid(s);

            Assert.That(result, Is.False);

        }

        [Test]
        public void Valid_Parentheses_One_Back_Parentheses_False()
        {
            string s = ")(";
            var solution = new _020_Valid_Parentheses();
            var result = solution.IsValid(s);

            Assert.That(result, Is.False);

        }

          [Test]
        public void Valid_Parentheses_Three_Back_Parentheses_False()
        {
            string s = ")(){}";
            var solution = new _020_Valid_Parentheses();
            var result = solution.IsValid(s);

            Assert.That(result, Is.False);

        }
    }

}
