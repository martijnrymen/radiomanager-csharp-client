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
    ///  Class for testing BlockApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BlockApiTests
    {
        private BlockApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BlockApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BlockApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BlockApi
            //Assert.IsInstanceOfType(typeof(BlockApi), instance, "instance is a BlockApi");
        }

        
        /// <summary>
        /// Test GetBlockById
        /// </summary>
        [Test]
        public void GetBlockByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //long? externalStationId = null;
            //var response = instance.GetBlockById(id, externalStationId);
            //Assert.IsInstanceOf<BlockResult> (response, "response is BlockResult");
        }
        
        /// <summary>
        /// Test GetCurrentBlock
        /// </summary>
        [Test]
        public void GetCurrentBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCurrentBlock();
            //Assert.IsInstanceOf<BlockResult> (response, "response is BlockResult");
        }
        
        /// <summary>
        /// Test GetNextBlock
        /// </summary>
        [Test]
        public void GetNextBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetNextBlock();
            //Assert.IsInstanceOf<BlockResult> (response, "response is BlockResult");
        }
        
        /// <summary>
        /// Test ListBlocks
        /// </summary>
        [Test]
        public void ListBlocksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? page = null;
            //DateTime? startMin = null;
            //DateTime? startMax = null;
            //long? broadcastId = null;
            //long? programId = null;
            //long? itemId = null;
            //long? externalStationId = null;
            //var response = instance.ListBlocks(page, startMin, startMax, broadcastId, programId, itemId, externalStationId);
            //Assert.IsInstanceOf<BlockResults> (response, "response is BlockResults");
        }
        
    }

}