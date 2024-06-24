/*
 * FastAPI
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using com.arpg.api.Client;
using com.arpg.api.arpg;
// uncomment below to import models
//using com.arpg.api.Model;

namespace com.arpg.api.Test.Api
{
    /// <summary>
    ///  Class for testing AuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthApiTests : IDisposable
    {
        private AuthApi instance;

        public AuthApiTests()
        {
            instance = new AuthApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuthApi
            //Assert.IsType<AuthApi>(instance);
        }

        /// <summary>
        /// Test AuthUnityLoginAuthJwtLoginPost
        /// </summary>
        [Fact]
        public void AuthUnityLoginAuthJwtLoginPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string password = null;
            //string? grantType = null;
            //string? scope = null;
            //string? clientId = null;
            //string? clientSecret = null;
            //var response = instance.AuthUnityLoginAuthJwtLoginPost(username, password, grantType, scope, clientId, clientSecret);
            //Assert.IsType<BearerResponse>(response);
        }

        /// <summary>
        /// Test AuthUnityLogoutAuthJwtLogoutPost
        /// </summary>
        [Fact]
        public void AuthUnityLogoutAuthJwtLogoutPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AuthUnityLogoutAuthJwtLogoutPost();
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SecureEndpointAuthSecureEndpointGet
        /// </summary>
        [Fact]
        public void SecureEndpointAuthSecureEndpointGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecureEndpointAuthSecureEndpointGet();
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test VerifyRequestTokenAuthRequestVerifyTokenPost
        /// </summary>
        [Fact]
        public void VerifyRequestTokenAuthRequestVerifyTokenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BodyVerifyRequestTokenAuthRequestVerifyTokenPost bodyVerifyRequestTokenAuthRequestVerifyTokenPost = null;
            //var response = instance.VerifyRequestTokenAuthRequestVerifyTokenPost(bodyVerifyRequestTokenAuthRequestVerifyTokenPost);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test VerifyVerifyAuthVerifyPost
        /// </summary>
        [Fact]
        public void VerifyVerifyAuthVerifyPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BodyVerifyVerifyAuthVerifyPost bodyVerifyVerifyAuthVerifyPost = null;
            //var response = instance.VerifyVerifyAuthVerifyPost(bodyVerifyVerifyAuthVerifyPost);
            //Assert.IsType<UserRead>(response);
        }
    }
}