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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersApi
            //Assert.IsType<UsersApi>(instance);
        }

        /// <summary>
        /// Test UsersCurrentUserUsersMeGet
        /// </summary>
        [Fact]
        public void UsersCurrentUserUsersMeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UsersCurrentUserUsersMeGet();
            //Assert.IsType<UserRead>(response);
        }

        /// <summary>
        /// Test UsersDeleteUserUsersIdDelete
        /// </summary>
        [Fact]
        public void UsersDeleteUserUsersIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.UsersDeleteUserUsersIdDelete(id);
        }

        /// <summary>
        /// Test UsersPatchCurrentUserUsersMePatch
        /// </summary>
        [Fact]
        public void UsersPatchCurrentUserUsersMePatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserUpdate userUpdate = null;
            //var response = instance.UsersPatchCurrentUserUsersMePatch(userUpdate);
            //Assert.IsType<UserRead>(response);
        }

        /// <summary>
        /// Test UsersPatchUserUsersIdPatch
        /// </summary>
        [Fact]
        public void UsersPatchUserUsersIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UserUpdate userUpdate = null;
            //var response = instance.UsersPatchUserUsersIdPatch(id, userUpdate);
            //Assert.IsType<UserRead>(response);
        }

        /// <summary>
        /// Test UsersUserUsersIdGet
        /// </summary>
        [Fact]
        public void UsersUserUsersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.UsersUserUsersIdGet(id);
            //Assert.IsType<UserRead>(response);
        }
    }
}
