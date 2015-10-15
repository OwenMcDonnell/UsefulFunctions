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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using dllFuncs = FonctionsUtiles.Fred.Csharp;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestStringExtensions
  {
    #region ToCamelCase
    [TestMethod]
    public void TestMethod_ToCamelCase()
    {
      const string source = "a long long time ago in a galaxy far far away";
      const string expected = "A long long time ago in a galaxy far far away";
      string result = dllFuncs.StringExtensions.ToCamelCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToCamelCase_Empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = dllFuncs.StringExtensions.ToCamelCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToCamelCase_underscore()
    {
      const string source = "a_long_long_time_ago_in_a_galaxy_far_far_away";
      const string expected = "ALongLongTimeAgoInAGalaxyFarFarAway";
      string result = dllFuncs.StringExtensions.ToCamelCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToCamelCase_one_underscore()
    {
      const string source = "a long long time ago_in a galaxy far far away";
      const string expected = "A long long time agoIn a galaxy far far away";
      string result = dllFuncs.StringExtensions.ToCamelCase(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToCamelCase_one_underscore_Upper_case()
    {
      const string source = "A long long time ago_In a galaxy far far away";
      const string expected = "A long long time agoIn a galaxy far far away";
      string result = dllFuncs.StringExtensions.ToCamelCase(source);
      Assert.AreEqual(result, expected);
    }
    #endregion ToCamelCase
    #region Uncapitalize
    [TestMethod]
    public void TestMethod_Uncapitalize_Empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = dllFuncs.StringExtensions.Uncapitalize(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Uncapitalize()
    {
      const string source = "A long long time ago in a galaxy far far away";
      const string expected = "a long long time ago in a galaxy far far away";
      string result = dllFuncs.StringExtensions.Uncapitalize(source);
      Assert.AreEqual(result, expected);
    }
    #endregion Uncapitalize
    #region ToCodeSummary
    //[TestMethod]
    //public void TestMethod_ToCodeSummary()
    //{
    //  const string source1 = "code1\ncodeline2";
    //  const int source2 = 1;
    //  string expected = "code1" + Environment.NewLine +  "/// codeline2";
    //  string result = dllFuncs.StringExtensions.ToCodeSummary(source1, source2);
    //  Assert.AreEqual(result, expected);
    //}
    #endregion ToCodeSummary


  }
}