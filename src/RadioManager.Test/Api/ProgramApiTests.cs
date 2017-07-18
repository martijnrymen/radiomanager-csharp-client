/* 
 * Pluxbox Radiomanager Client
 *
 * Pluxbox RadioManager gives you the power, flexibility and speed you always wanted in a lightweight and easy-to-use web-based radio solution. With Pluxbox RadioManager you can organise your radio workflow and automate your omnichannel communication with your listeners. We offer wide range specialised services for the radio and connections like Hybrid Radio, Visual Radio, your website and social media without losing focus on your broadcast. For more information visit https://pluxbox.com
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
    ///  Class for testing ProgramApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProgramApiTests
    {
        private ProgramApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProgramApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProgramApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProgramApi
            //Assert.IsInstanceOfType(typeof(ProgramApi), instance, "instance is a ProgramApi");
        }

        
        /// <summary>
        /// Test CreateProgram
        /// </summary>
        [Test]
        public void CreateProgramTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProgramDataInput data = null;
            //var response = instance.CreateProgram(data);
            //Assert.IsInstanceOf<PostSuccess> (response, "response is PostSuccess");
        }
        
        /// <summary>
        /// Test DeleteProgramById
        /// </summary>
        [Test]
        public void DeleteProgramByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.DeleteProgramById(id);
            //Assert.IsInstanceOf<Success> (response, "response is Success");
        }
        
        /// <summary>
        /// Test GetProgramById
        /// </summary>
        [Test]
        public void GetProgramByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //long? externalStationId = null;
            //var response = instance.GetProgramById(id, externalStationId);
            //Assert.IsInstanceOf<ProgramResult> (response, "response is ProgramResult");
        }
        
        /// <summary>
        /// Test ListPrograms
        /// </summary>
        [Test]
        public void ListProgramsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? page = null;
            //long? genreId = null;
            //long? modelTypeId = null;
            //long? presenterId = null;
            //long? tagId = null;
            //long? broadcastId = null;
            //long? itemId = null;
            //long? blockId = null;
            //long? externalStationId = null;
            //var response = instance.ListPrograms(page, genreId, modelTypeId, presenterId, tagId, broadcastId, itemId, blockId, externalStationId);
            //Assert.IsInstanceOf<ProgramResults> (response, "response is ProgramResults");
        }
        
        /// <summary>
        /// Test UpdateProgramByID
        /// </summary>
        [Test]
        public void UpdateProgramByIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //ProgramDataInput data = null;
            //var response = instance.UpdateProgramByID(id, data);
            //Assert.IsInstanceOf<Success> (response, "response is Success");
        }
        
    }

}