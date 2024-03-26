using FluentAssertions;
using PyramidArrayKata;

namespace PyramidArrayTests
{
    public class PyramidArrayTests
    {
        [Fact]
        public void CreateArray_ShouldReturn_ArrayWithLengthOfInput()
        {
            int input = 3;
            int lengthOfArray = PyramidArray.CreateArray(input);
            lengthOfArray.Should().Be(input);

        }

        [Fact]
        public void CreateJaggedArray_ShouldReturn_JaggedArrayWithLengthOfInput()
        {
            int input = 3;
            int lengthOfJaggedArray = PyramidArray.CreateJaggedArray(input);
            lengthOfJaggedArray.Should().Be(input);
        }

        [Fact]
        public void FullJaggedArray_ShouldReturn_JaggedArrayWithValues()
        {
            int input = 3;
            int[][] jaggedArray = new int[input][];
            jaggedArray[0] = new int[] {1};
            jaggedArray[1] = new int[] {1,1};
            jaggedArray[2] = new int[] {1,1,1};
            int[][] fullJaggedArray = PyramidArray.FullJaggedArray(input);
            fullJaggedArray.Should().BeEquivalentTo(jaggedArray);
        }

    }
}

