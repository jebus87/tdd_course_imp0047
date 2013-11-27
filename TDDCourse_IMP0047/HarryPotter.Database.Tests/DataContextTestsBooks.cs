using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ImproveIT.Data;
using System.Data;
using HarryPotter.Domain;
using System.Configuration;
using NDbUnit.Core;

namespace HarryPotter.Database.Tests
{
    [TestFixture]
    class DataContextTestsBooks
    {
        private IDataContext _dataContext;
        private INDbUnitTest _ndbUnitTest;

        [SetUp]
        public void Setup()
        {
            string cnn = ConfigurationManager.ConnectionStrings["storedb_development"].ConnectionString;
            this._ndbUnitTest = new NDbUnit.Core.SqlClient.SqlDbUnitTest(cnn);
            this._ndbUnitTest.ReadXmlSchema("StoreSchema.xsd");
            this._ndbUnitTest.PerformDbOperation(NDbUnit.Core.DbOperationFlag.DeleteAll);

            NHibernate.ISession session = HarryPotter.Database.DataContextBuilder.BuildSession();

            this._dataContext = new ImproveIT.Data.Hibernate.HibernateDataContext(session);
        }

        [Test]
        public void Add_NoBooksInDatabase3Author_OneBookInsertedWithAuthor()
        {
            //Arrange
            this._ndbUnitTest.ReadXml("data/authors.xml");
            this._ndbUnitTest.PerformDbOperation(NDbUnit.Core.DbOperationFlag.Insert);
            Author author = this._dataContext.GetById<Author>(1);

            //Act
            Book book = new Book(){Name="Book 01", Price = 8, Author = author};
            this._dataContext.Add<Book>(book);

            //Assert
            DataSet dataSet = this._ndbUnitTest.GetDataSetFromDb();
        }

        [Test]
        public void GetById_OneBookInDatabase3Author_OneBookRetrived()
        {
            //Arrange
            this._ndbUnitTest.ReadXml("data/authors.xml");
            this._ndbUnitTest.PerformDbOperation(NDbUnit.Core.DbOperationFlag.Insert);
            this._ndbUnitTest.ReadXml("data/books.xml");
            this._ndbUnitTest.PerformDbOperation(NDbUnit.Core.DbOperationFlag.Insert);

            //Act
            Book book = this._dataContext.GetById<Book>(1);

            //Assert
            Assert.IsNotNull(book);
            Assert.IsNotNull(book.Author);

        }
    }
}
