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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using MathFunc = FonctionsUtiles.Fred.Csharp.FunctionsMath;
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;
using DateFunc = FonctionsUtiles.Fred.Csharp.FunctionsDateTime;
using InternetFunc = FonctionsUtiles.Fred.Csharp.FunctionsInternet;
using FonctionsUtiles.Fred.Csharp;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionsInternet
  {
    #region IsInternetConnected

    //**********************IsInternetConnected***************
    [TestMethod]
    public void TestMethod_IsInternetConnected_true()
    {
      const bool expected = true;
      bool result = InternetFunc.IsInternetConnected();
      Assert.AreEqual(result, expected);
    }

    #endregion IsInternetConnected
    #region IsNetworkLikelyAvailable

    //**********************IsNetworkLikelyAvailable***************
    [TestMethod]
    public void TestMethod_IsNetworkLikelyAvailable_true()
    {
      const bool expected = true;
      bool result = InternetFunc.IsNetworkLikelyAvailable();
      Assert.AreEqual(result, expected);
    }

    #endregion IsNetworkLikelyAvailable
    #region IsNetworkLikelyAvailable

    //**********************IsOnenNetworkCardAvailable***************
    [TestMethod]
    public void TestMethod_IsOnenNetworkCardAvailable_true()
    {
      const bool expected = true;
      bool result = InternetFunc.IsOnenNetworkCardAvailable();
      Assert.AreEqual(result, expected);
    }

    #endregion IsOnenNetworkCardAvailable
  }
}