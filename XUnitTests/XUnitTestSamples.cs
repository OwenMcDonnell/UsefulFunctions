﻿/*
The MIT License(MIT)
Copyright(c) 2015 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTests
{
  public class XUnitTestSamples
  {
    [Fact]
    public void EqualStringIgnoreCase()
    {
      string expected = "TestString";
      string actual = "teststring";

      Assert.False(actual == expected);
      Assert.NotEqual(expected, actual);
      Assert.Equal(expected, actual, StringComparer.CurrentCultureIgnoreCase);
    }

    class DateComparer : IEqualityComparer<DateTime>
    {
      public bool Equals(DateTime x, DateTime y)
      {
        return x.Date == y.Date;
      }

      public int GetHashCode(DateTime obj)
      {
        return obj.GetHashCode();
      }
    }

    [Fact]
    public void DateShouldBeEqualEvenThoughTimesAreDifferent()
    {
      DateTime firstTime = DateTime.Now.Date;
      DateTime later = firstTime.AddMinutes(90);

      Assert.NotEqual(firstTime, later);
      Assert.Equal(firstTime, later, new DateComparer());
    }
  }
}