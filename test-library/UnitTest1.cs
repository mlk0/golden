using System;
using library;
using Xunit;
 
using Shouldly;

namespace test_library
{
    public class UnitTest1
    {


        [Fact]
        public void Thing_Get_should_assert_equality_of_the_sum_of_2_and_3_to_be_5(){

            Assert.Equal(5, new Thing().Get(2,3));
        }

        [Fact]
        public void Thing_Get_should_return_5_when_summing_2_and_3(){
            var sut = new Thing();

            sut.Get(2,3).ShouldBe(5);
        }
    }
}
