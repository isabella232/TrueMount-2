﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrueMount {
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
    internal class SettingsMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SettingsMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TrueMount.SettingsMessages", typeof(SettingsMessages).Assembly);
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
        ///   Looks up a localized string similar to , Letter .
        /// </summary>
        internal static string CBoxLetter {
            get {
                return ResourceManager.GetString("CBoxLetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to , Partition .
        /// </summary>
        internal static string CBoxPartition {
            get {
                return ResourceManager.GetString("CBoxPartition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate detected.
        /// </summary>
        internal static string MsgHDevDouble {
            get {
                return ResourceManager.GetString("MsgHDevDouble", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Chosen disk offline.
        /// </summary>
        internal static string MsgHDiskOff {
            get {
                return ResourceManager.GetString("MsgHDiskOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password file missing.
        /// </summary>
        internal static string MsgHNoPw {
            get {
                return ResourceManager.GetString("MsgHNoPw", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning.
        /// </summary>
        internal static string MsgHNoTCSet {
            get {
                return ResourceManager.GetString("MsgHNoTCSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Success.
        /// </summary>
        internal static string MsgHSaved {
            get {
                return ResourceManager.GetString("MsgHSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected Key Device already exists!.
        /// </summary>
        internal static string MsgTDevDouble {
            get {
                return ResourceManager.GetString("MsgTDevDouble", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The chosen disk seems to be offline, please reopen this dialog!.
        /// </summary>
        internal static string MsgTDiskOff {
            get {
                return ResourceManager.GetString("MsgTDiskOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select a password file!.
        /// </summary>
        internal static string MsgTNoPw {
            get {
                return ResourceManager.GetString("MsgTNoPw", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You did not set a valid TrueCrypt path, TrueMount will not work!.
        /// </summary>
        internal static string MsgTNoTCSet {
            get {
                return ResourceManager.GetString("MsgTNoTCSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings saved successfully!.
        /// </summary>
        internal static string MsgTSaved {
            get {
                return ResourceManager.GetString("MsgTSaved", resourceCulture);
            }
        }
    }
}
