﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Localization.Languages.Admin.Controllers {
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
    public class Plugin {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Plugin() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Localization.Languages.Admin.Controllers.Plugin", typeof(Plugin).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugin doesn&apos;t exist..
        /// </summary>
        public static string NotFound {
            get {
                return ResourceManager.GetString("NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugin has been deleted succesfully..
        /// </summary>
        public static string SuccessfullyDeleted {
            get {
                return ResourceManager.GetString("SuccessfullyDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugin has been disabled..
        /// </summary>
        public static string SuccessfullyDisabled {
            get {
                return ResourceManager.GetString("SuccessfullyDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugin has been enabled..
        /// </summary>
        public static string SuccessfullyEnabled {
            get {
                return ResourceManager.GetString("SuccessfullyEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugin has been successfully installed..
        /// </summary>
        public static string SuccessfullyInstalled {
            get {
                return ResourceManager.GetString("SuccessfullyInstalled", resourceCulture);
            }
        }
    }
}
