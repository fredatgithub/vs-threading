﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.Threading {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.Threading.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to A non-upgradeable read lock is held by the caller and cannot be upgraded..
        /// </summary>
        internal static string CannotUpgradeNonUpgradeableLock {
            get {
                return ResourceManager.GetString("CannotUpgradeNonUpgradeableLock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation can only be executed against a valid lock..
        /// </summary>
        internal static string InvalidLock {
            get {
                return ResourceManager.GetString("InvalidLock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lazily created value faulted during construction..
        /// </summary>
        internal static string LazyValueFaulted {
            get {
                return ResourceManager.GetString("LazyValueFaulted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lazily created value not yet constructed..
        /// </summary>
        internal static string LazyValueNotCreated {
            get {
                return ResourceManager.GetString("LazyValueNotCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This lock has already been marked for completion.  No new top-level locks can be serviced..
        /// </summary>
        internal static string LockCompletionAlreadyRequested {
            get {
                return ResourceManager.GetString("LockCompletionAlreadyRequested", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value factory has called for the value on the same instance..
        /// </summary>
        internal static string ValueFactoryReentrancy {
            get {
                return ResourceManager.GetString("ValueFactoryReentrancy", resourceCulture);
            }
        }
    }
}