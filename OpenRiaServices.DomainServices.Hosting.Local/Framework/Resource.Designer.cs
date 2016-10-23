﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenRiaServices.DomainServices.Hosting.Local {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenRiaServices.DomainServices.Hosting.Local.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to The object reference is not a valid DomainService proxy instance..
        /// </summary>
        internal static string DomainServiceProxy_InvalidProxyType {
            get {
                return ResourceManager.GetString("DomainServiceProxy_InvalidProxyType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred during execution of the DomainService operation. Inspect the OperationErrors property for more information..
        /// </summary>
        internal static string DomainServiceProxy_OperationError {
            get {
                return ResourceManager.GetString("DomainServiceProxy_OperationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The query operation &apos;{0}&apos; was not found on DomainService type &apos;{1}&apos;..
        /// </summary>
        internal static string DomainServiceProxy_QueryOperationNotFound {
            get {
                return ResourceManager.GetString("DomainServiceProxy_QueryOperationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; must be public..
        /// </summary>
        internal static string DomainServiceProxyGenerator_ExpectedPublicType {
            get {
                return ResourceManager.GetString("DomainServiceProxyGenerator_ExpectedPublicType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DomainService contract &apos;{0}&apos; has methods which are not defined in the DomainServiceDescription for type &apos;{1}&apos;. Unable to generate proxy implementations for the following methods: {2}.
        /// </summary>
        internal static string DomainServiceProxyGenerator_MethodCountMismatch {
            get {
                return ResourceManager.GetString("DomainServiceProxyGenerator_MethodCountMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to locate a method named &apos;{1}&apos; with a matching signature in contract &apos;{0}&apos; ..
        /// </summary>
        internal static string DomainServiceProxyGenerator_OperationMismatch {
            get {
                return ResourceManager.GetString("DomainServiceProxyGenerator_OperationMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DomainService proxies do not support &apos;{0}&apos; operations..
        /// </summary>
        internal static string DomainServiceProxyGenerator_OperationNotSupported {
            get {
                return ResourceManager.GetString("DomainServiceProxyGenerator_OperationNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to generate proxy for contract &apos;{0}&apos; because the method &apos;{1}&apos; is overloaded..
        /// </summary>
        internal static string DomainServiceProxyGenerator_OverridesNotSupported {
            get {
                return ResourceManager.GetString("DomainServiceProxyGenerator_OverridesNotSupported", resourceCulture);
            }
        }
    }
}
