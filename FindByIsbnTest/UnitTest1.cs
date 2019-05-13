using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
namespace FindByIsbnTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void FindByIsbn_9787502221881_ExpectIsbnAreEqual()
        {
            //arrange
            var bookMange = new BookManage();
            bookMange.SetBooks(ObjectData.Books);
            //act
            var book = bookMange.FindByIsbn("9787502221881");
            //assert
            Assert.AreEqual("9787502221881", book[0].Isbn);
        }
    }
}
