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
    ///  Class for testing StringApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StringApiTests
    {
        private StringApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StringApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StringApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StringApi
            //Assert.IsInstanceOfType(typeof(StringApi), instance, "instance is a StringApi");
        }

        
        /// <summary>
        /// Test GetStringsByName
        /// </summary>
        [Test]
        public void GetStringsByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //bool? fullModel = null;
            //var response = instance.GetStringsByName(name, fullModel);
            //Assert.IsInstanceOf<TextString> (response, "response is TextString");
        }
        
    }

}