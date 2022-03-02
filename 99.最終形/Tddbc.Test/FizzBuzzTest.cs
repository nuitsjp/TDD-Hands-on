using System.Diagnostics;
using Xunit;

namespace Tddbc.Test
{
    namespace FizzBuzz����ƕϊ��K��������FizzBuzz�N���X
    {
        namespace Convert���\�b�h�͐��𕶎���ɂɕϊ�����
        {
            public class _3�̔{���̎��͐��̑����Fizz�ɕϊ����� : FizzBuzzTestBase
            {
                [Fact]
                public void _3��n���ƕ�����Fizz��Ԃ�()
                {
                    // ���� & ���s
                    Assert.Equal("Fizz", FizzBuzz.Convert(3));
                }
            }

            public class _5�̔{���̎��͐��̑����Buzz�ɕϊ����� : FizzBuzzTestBase
            {
                [Fact]
                public void _5��n���ƕ�����Buzz��Ԃ�()
                {
                    // ���� & ���s
                    Assert.Equal("Buzz", FizzBuzz.Convert(5));
                }
            }

            public class ���̑��̐��̎��͂��̂܂ܕ�����ɕϊ����� : FizzBuzzTestBase
            {
                [Fact]
                public void _1��n���ƕ�����1��Ԃ�()
                {
                    // ���� & ���s
                    Assert.Equal("1", FizzBuzz.Convert(1));
                }
            }
        }

        public class FizzBuzzTestBase
        {
            protected readonly FizzBuzz FizzBuzz;

            public FizzBuzzTestBase()
            {
                FizzBuzz = new FizzBuzz();
            }

        }
    }
}