using System.Diagnostics;
using Xunit;

namespace Tddbc.Test
{
    namespace FizzBuzz数列と変換規則を扱うFizzBuzzクラス
    {
        namespace Convertメソッドは数を文字列にに変換する
        {
            public class _3の倍数の時は数の代わりにFizzに変換する : FizzBuzzTestBase
            {
                [Fact]
                public void _3を渡すと文字列Fizzを返す()
                {
                    // 検証 & 実行
                    Assert.Equal("Fizz", FizzBuzz.Convert(3));
                }
            }

            public class _5の倍数の時は数の代わりにBuzzに変換する : FizzBuzzTestBase
            {
                [Fact]
                public void _5を渡すと文字列Buzzを返す()
                {
                    // 検証 & 実行
                    Assert.Equal("Buzz", FizzBuzz.Convert(5));
                }
            }

            public class その他の数の時はそのまま文字列に変換する : FizzBuzzTestBase
            {
                [Fact]
                public void _1を渡すと文字列1を返す()
                {
                    // 検証 & 実行
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