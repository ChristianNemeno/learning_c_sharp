
using largest_elem;
namespace largest_elem.Tests

{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var numbers = new List<int> { 1, 5, 10, 2, 19, 3 };
            
            var result = solution.Largest(numbers);

            Assert.Equal(19, result);
        }



    }
}