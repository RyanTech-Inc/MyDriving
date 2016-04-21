// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System;
using System.Collections.Generic;
using MyDriving.Utils.Interfaces;
using System.Collections;
using System.Threading.Tasks;

namespace MyDriving.Utils
{
    public class Logger : ILogger
    {
        static ILogger _instance;
        public static string HockeyAppiOS => "09f39eb0435c431ebe954f6faf3a1537";
        public static string HockeyAppAndroid => "5c36e9be390249b38396182b3febd13f"; //RyanTech API Key
        public static string HockeyAppUWP => "4c2c02e2a539421eb9efcc374b9344ee"; //RyanTech API key
        /// <summary>
        /// You can generate a key from: www.bingmapsportal.com
        /// This enables maps to show on the Past Trips screen
        /// </summary>
        public static string BingMapsAPIKey => "vXnuTW8WomNrHTGSDvgp~twjbcraJ_zxkwGlrZu2PwQ~AvFOYkbMZOx6D5h41QGR13AmGw7YRlceY9BvgjKencYEc3SmUk03QeoEqz8vjgPO"; //Ryantech Key

        public static ILogger Instance => _instance ?? (_instance = ServiceLocator.Instance.Resolve<ILogger>());

        #region ILogger implementation

        public virtual void WriteLine(string line)
        {
        }

        public virtual void Identify(string uid, IDictionary<string, string> table = null)
        {
          
        }

        public virtual void Identify(string uid, string key, string value)
        {
            
        }

        public virtual void Track(string trackIdentifier, IDictionary<string, string> table = null)
        {
           
        }

        public virtual void Track(string trackIdentifier, string key, string value)
        {
           
        }

        public virtual ITrackHandle TrackTime(string identifier, IDictionary<string, string> table = null)
        {
            return null;
        }

        public virtual ITrackHandle TrackTime(string identifier, string key, string value)
        {
            return null;

        }

        public virtual void Report(Exception exception = null, Severity warningLevel = Severity.Warning)
        {
 
        }

        public virtual void Report(Exception exception, IDictionary extraData, Severity warningLevel = Severity.Warning)
        {
           
        }

        public virtual void Report(Exception exception, string key, string value,
            Severity warningLevel = Severity.Warning)
        {
            
        }

        public virtual Task Save()
        {
            return Task.FromResult(true);
        }

        public virtual Task PurgePendingCrashReports()
        {
            return Task.FromResult(true);
        }

        

        #endregion
    }
    
}