/* 
 * RadioManager
 *
 * RadioManager
 *
 * OpenAPI spec version: 2.0
 * Contact: support@pluxbox.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using RadioManager.Client;
using RadioManager.Api;
using RadioManager.Model;

namespace RadioManager.Test
{
    /// <summary>
    ///  Class for testing GenreApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GenreApiTests
    {
        private GenreApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GenreApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GenreApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GenreApi
            //Assert.IsInstanceOfType(typeof(GenreApi), instance, "instance is a GenreApi");
        }

        
        /// <summary>
        /// Test GetGenreById
        /// </summary>
        [Test]
        public void GetGenreByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //long? externalStationId = null;
            //var response = instance.GetGenreById(id, externalStationId);
            //Assert.IsInstanceOf<GenreResult> (response, "response is GenreResult");
        }
        
        /// <summary>
        /// Test ListGenres
        /// </summary>
        [Test]
        public void ListGenresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? page = null;
            //long? parentId = null;
            //long? programId = null;
            //long? broadcastId = null;
            //long? externalStationId = null;
            //var response = instance.ListGenres(page, parentId, programId, broadcastId, externalStationId);
            //Assert.IsInstanceOf<GenreResults> (response, "response is GenreResults");
        }
        
    }

}
