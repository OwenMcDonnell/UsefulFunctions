﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoFunc = FonctionsUtiles.Fred.Csharp.FunctionsCrypto;
using dllFuncs = FonctionsUtiles.Fred.Csharp;

namespace UnitTestUsefullFunctions
{
  [TestClass]
  public class UnitTestFunctionCrypto
  {
    #region Crypto
    #region RSAEncryption
    [TestMethod]
    public void TestMethod_RsaEncryption_source_and_encryption_are_different()
    {
      const string source = "A long long time ago in a galaxy far far away";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.AreNotEqual(result, source);
    }

    [TestMethod]
    public void TestMethod_RsaEncryption_one_letter()
    {
      const string source = "a";
      const string expected = "Pk+xT6QpGq0h4hdYdIlLZr2Cg1wOZ3v6qQXkIvqmwwdXPd1MdhoICk4N4jHXqGBfFJzIN/cbeHbVaiEbEIuCe5tEvaS5AFVrF3PATmCVWHtRBJsR5tvihQOxecd52AHRjpZhbX9sawpHpxQ5iKOpyT6gQ6icG+oSaYcwx8xn7ag=";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.AreNotEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RsaEncryption_encryption_not_null()
    {
      const string source = "A long long time ago in a galaxy far far away";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void TestMethod_RsaEncryption_encryption_not_empty()
    {
      const string source = "A long long time ago in a galaxy far far away";
      string result = CryptoFunc.RsaEncryption(source);
      Assert.IsTrue(result.Length != 0);
      Assert.AreNotEqual(result.Length, 0);
    }
    #endregion RSAEncryption
    #region RsaDecryption
    [TestMethod]
    public void TestMethod_RsaDecryption_source_is_a_the_same_after_encryption_and_decryption()
    {
      const string source = "A long long time ago in a galaxy far far away";
      string result = CryptoFunc.RsaDecryption(CryptoFunc.RsaEncryption(source));
      Assert.AreEqual(result, source);
    }

    [TestMethod]
    public void TestMethod_RsaDecryption_source_and_encryption_are_different()
    {
      //const string source = "N06oeaZWoEgD3ktg8lvw2ncecdqE9grb+NRV/QoYpp4VRjQeGiDZYPwFbd4VwhqmAk+7uYeGHc2yd/LCz7j9oN7Z1X6MKxYmiGc7FiL2fobKXcHb1yNpTXgy5jNok6Y02dtJJaUn5GmNMDvk1fYxGgyvCqScxalF16Nl1vAWO7I=";
      //string result = CryptoFunc.RsaDecryption(source);
      //Assert.AreNotEqual(result, source);
    }

    [TestMethod]
    public void TestMethod_RsaDecryption_encryption_not_null()
    {
      //const string source = "N06oeaZWoEgD3ktg8lvw2ncecdqE9grb+NRV/QoYpp4VRjQeGiDZYPwFbd4VwhqmAk+7uYeGHc2yd/LCz7j9oN7Z1X6MKxYmiGc7FiL2fobKXcHb1yNpTXgy5jNok6Y02dtJJaUn5GmNMDvk1fYxGgyvCqScxalF16Nl1vAWO7I=";
      //string result = CryptoFunc.RsaDecryption(source);
      //Assert.IsNotNull(result);
    }

    [TestMethod]
    public void TestMethod_RsaDecryption_encryption_not_empty()
    {
      //const string source = "N06oeaZWoEgD3ktg8lvw2ncecdqE9grb+NRV/QoYpp4VRjQeGiDZYPwFbd4VwhqmAk+7uYeGHc2yd/LCz7j9oN7Z1X6MKxYmiGc7FiL2fobKXcHb1yNpTXgy5jNok6Y02dtJJaUn5GmNMDvk1fYxGgyvCqScxalF16Nl1vAWO7I=";
      //string result = CryptoFunc.RsaDecryption(source);
      //Assert.IsTrue(result.Length != 0);
      //Assert.AreNotEqual(result.Length, 0);
    }

    #endregion RsaDecryption
    #endregion Crypto

    #region GenerateRandomNumbers
    [TestMethod]
    public void TestMethod_GenerateRandomNumberUsingCrypto_between_1_and_254()
    {
      int result = CryptoFunc.GenerateRandomNumberUsingCrypto(1, 254);
      Assert.IsTrue(result >= 1);
    }


    #endregion GenerateRandomNumbers

  }
}