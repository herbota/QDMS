﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QDMSServer.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QDMSServer.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version 0.9.2
        ///- Slight change to the way adding new instruments works. You now received the added instrument in response to the addition request.
        ///
        ///Version 0.9.1
        ///- Client update: renamed extension method to prevent naming clash with Math.NET Numerics library.
        ///
        ///Version 0.9.0
        ///- Changed ZeroMQ libraries from clrzmq to NetMQ, streamlining a lot of server code in the process.
        ///	ATTENTION! If you are using the NuGet QDMS Client package you need to update it to work with the latest version of the server. Not [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CHANGELOG {
            get {
                return ResourceManager.GetString("CHANGELOG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # By: Ron Cordell - roncordell
        ///#  I didn&apos;t see this anywhere, so I thought I&apos;d post it here. This is the script from Quartz to create the tables in a MySQL database, modified to use INNODB instead of MYISAM.
        ///
        ///DROP TABLE IF EXISTS QRTZ_FIRED_TRIGGERS;
        ///DROP TABLE IF EXISTS QRTZ_PAUSED_TRIGGER_GRPS;
        ///DROP TABLE IF EXISTS QRTZ_SCHEDULER_STATE;
        ///DROP TABLE IF EXISTS QRTZ_LOCKS;
        ///DROP TABLE IF EXISTS QRTZ_SIMPLE_TRIGGERS;
        ///DROP TABLE IF EXISTS QRTZ_SIMPROP_TRIGGERS;
        ///DROP TABLE IF EXISTS QRTZ_CRON_TRIGGERS;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QuartzMySqlDbInit {
            get {
                return ResourceManager.GetString("QuartzMySqlDbInit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N&apos;[dbo].[FK_QRTZ_TRIGGERS_QRTZ_JOB_DETAILS]&apos;) AND OBJECTPROPERTY(id, N&apos;ISFOREIGNKEY&apos;) = 1)
        ///ALTER TABLE [dbo].[QRTZ_TRIGGERS] DROP CONSTRAINT FK_QRTZ_TRIGGERS_QRTZ_JOB_DETAILS
        ///GO
        ///
        ///IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N&apos;[dbo].[FK_QRTZ_CRON_TRIGGERS_QRTZ_TRIGGERS]&apos;) AND OBJECTPROPERTY(id, N&apos;ISFOREIGNKEY&apos;) = 1)
        ///ALTER TABLE [dbo].[QRTZ_CRON_TRIGGERS] DROP CONSTRAINT FK_QRTZ_CRON_TRIGGERS_QRTZ_TRIGGERS
        ///GO
        ///
        ///IF EXISTS (SELE [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QuartzSqlServerDbInit {
            get {
                return ResourceManager.GetString("QuartzSqlServerDbInit", resourceCulture);
            }
        }
    }
}
