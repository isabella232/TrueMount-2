﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace updater {
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
    internal class LanguageDictionary {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LanguageDictionary() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("updater.LanguageDictionary", typeof(LanguageDictionary).Assembly);
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
        ///   Looks up a localized string similar to Starting update process....
        /// </summary>
        internal static string BeginUpdate {
            get {
                return ResourceManager.GetString("BeginUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloaded: {0}%.
        /// </summary>
        internal static string DownloadProgress {
            get {
                return ResourceManager.GetString("DownloadProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No new version.
        /// </summary>
        internal static string MsgHNoNewVersion {
            get {
                return ResourceManager.GetString("MsgHNoNewVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update failed.
        /// </summary>
        internal static string MsgHUDownloadFail {
            get {
                return ResourceManager.GetString("MsgHUDownloadFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download succeeded.
        /// </summary>
        internal static string MsgHUDownloadOk {
            get {
                return ResourceManager.GetString("MsgHUDownloadOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update error.
        /// </summary>
        internal static string MsgHUpdateFail {
            get {
                return ResourceManager.GetString("MsgHUpdateFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No new version available at time..
        /// </summary>
        internal static string MsgTNoNewVersion {
            get {
                return ResourceManager.GetString("MsgTNoNewVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update could not be downloaded, try again later!.
        /// </summary>
        internal static string MsgTUDownloadFail {
            get {
                return ResourceManager.GetString("MsgTUDownloadFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update downloaded successfully!.
        /// </summary>
        internal static string MsgTUDownloadOk {
            get {
                return ResourceManager.GetString("MsgTUDownloadOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating failed!.
        /// </summary>
        internal static string MsgTUpdateFail {
            get {
                return ResourceManager.GetString("MsgTUpdateFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading new version....
        /// </summary>
        internal static string TitleDownloading {
            get {
                return ResourceManager.GetString("TitleDownloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Action failed.
        /// </summary>
        internal static string TitleFailed {
            get {
                return ResourceManager.GetString("TitleFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating finished.
        /// </summary>
        internal static string TitleFinished {
            get {
                return ResourceManager.GetString("TitleFinished", resourceCulture);
            }
        }
    }
}
