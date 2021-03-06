﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainCrypto;
using PlainCrypto.Abstract;

namespace PlainCryptoTest
{
    [TestClass]
    public class CryptoAES_Test
    {
        [TestMethod]
        public void CryptoAES_128Bit_FixedIV_Test()
        {
            //Arrange
            byte[] key = { 16, 120, 8, 56, 24, 89, 74, 91, 150, 14, 52, 99, 203, 87, 247, 3 };
            byte[] iv = { 23, 64, 89, 207, 178, 19, 63, 8, 145, 10, 39, 57, 56, 84, 250, 46 };

            CryptoSymmetric crypto = new CryptoAES(key);
            crypto.SetIV(iv);
            string originalMessage = "I love cryptography and AES128";
            string encryptedMessage = crypto.Encrypt(originalMessage);

            //Act
            string decryptedMessage = crypto.Decrypt(encryptedMessage);

            //Assert
            Assert.AreNotEqual(originalMessage, encryptedMessage);
            Assert.AreEqual(originalMessage, decryptedMessage);
        }

        [TestMethod]
        public void CryptoAES_128Bit_RandomIV_Test()
        {
            //Arrange
            byte[] key = { 16, 120, 8, 56, 24, 89, 74, 91, 150, 14, 52, 99, 203, 87, 247, 3 };

            ICrypto crypto = new CryptoAES(key);
            string originalMessage = "I love cryptography and AES128";
            string encryptedMessage = crypto.Encrypt(originalMessage);

            //Act
            string decryptedMessage = crypto.Decrypt(encryptedMessage);

            //Assert
            Assert.AreNotEqual(originalMessage, encryptedMessage);
            Assert.AreEqual(originalMessage, decryptedMessage);
        }

        [TestMethod]
        public void CryptoAES_192Bit_FixedIV_Test()
        {
            //Arrange
            byte[] key = { 11, 25, 3, 85, 201, 93, 102, 170, 27, 250, 231, 63, 74, 29, 14, 138, 64, 121, 227, 189, 42, 7, 52, 46 };
            byte[] iv = { 23, 64, 89, 207, 178, 19, 63, 8, 145, 10, 39, 57, 56, 84, 250, 46 };

            CryptoSymmetric crypto = new CryptoAES(key);
            crypto.SetIV(iv);
            string originalMessage = "I love cryptography and AES192";
            string encryptedMessage = crypto.Encrypt(originalMessage);

            //Act
            string decryptedMessage = crypto.Decrypt(encryptedMessage);

            //Assert
            Assert.AreNotEqual(originalMessage, encryptedMessage);
            Assert.AreEqual(originalMessage, decryptedMessage);
        }

        [TestMethod]
        public void CryptoAES_192Bit_RandomIV_Test()
        {
            //Arrange
            byte[] key = { 11, 25, 3, 85, 201, 93, 102, 170, 27, 250, 231, 63, 74, 29, 14, 138, 64, 121, 227, 189, 42, 7, 52, 46 };

            ICrypto crypto = new CryptoAES(key);
            string originalMessage = "I love cryptography and AES192";
            string encryptedMessage = crypto.Encrypt(originalMessage);

            //Act
            string decryptedMessage = crypto.Decrypt(encryptedMessage);

            //Assert
            Assert.AreNotEqual(originalMessage, encryptedMessage);
            Assert.AreEqual(originalMessage, decryptedMessage);
        }

        [TestMethod]
        public void CryptoAES_256Bit_FixedIV_Test()
        {
            //Arrange
            byte[] key = { 27, 1, 26, 2, 25, 3, 24, 4, 23, 5, 22, 255, 0, 75, 40, 63, 127, 40, 27, 18, 6, 21, 7, 20, 8, 18, 9, 19, 10, 17, 11, 16 };
            byte[] iv = { 23, 64, 89, 207, 178, 19, 63, 8, 145, 10, 39, 57, 56, 84, 250, 46 };

            CryptoSymmetric crypto = new CryptoAES(key);
            crypto.SetIV(iv);
            string originalMessage = "I love cryptography and the super secure AES256";
            string encryptedMessage = crypto.Encrypt(originalMessage);

            //Act
            string decryptedMessage = crypto.Decrypt(encryptedMessage);

            //Assert
            Assert.AreNotEqual(originalMessage, encryptedMessage);
            Assert.AreEqual(originalMessage, decryptedMessage);
        }

        [TestMethod]
        public void CryptoAES_256Bit_RandomIV_Test()
        {
            //Arrange
            byte[] key = { 27, 1, 26, 2, 25, 3, 24, 4, 23, 5, 22, 255, 0, 75, 40, 63, 127, 40, 27, 18, 6, 21, 7, 20, 8, 18, 9, 19, 10, 17, 11, 16 };

            ICrypto crypto = new CryptoAES(key);
            string originalMessage = "I love cryptography and the super secure AES256";
            string encryptedMessage = crypto.Encrypt(originalMessage);

            //Act
            string decryptedMessage = crypto.Decrypt(encryptedMessage);

            //Assert
            Assert.AreNotEqual(originalMessage, encryptedMessage);
            Assert.AreEqual(originalMessage, decryptedMessage);
        }
    }
}
