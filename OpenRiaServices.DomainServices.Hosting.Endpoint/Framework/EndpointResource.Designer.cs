﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenRiaServices.DomainServices.Hosting {
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
    internal class EndpointResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal EndpointResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenRiaServices.DomainServices.Hosting.EndpointResource", typeof(EndpointResource).Assembly);
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
        ///   Looks up a localized string similar to WCF RIA service traces can only be obtained in ATOM (default), XML or HTML format. Use URI &quot;.../traces?format=xml&quot; to request XML, or &quot;.../traces?format=html&quot; to request HTML.
        /// </summary>
        internal static string InvalidTraceFormat {
            get {
                return ResourceManager.GetString("InvalidTraceFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;maxEntries&apos; attribute must be a positive integer.
        /// </summary>
        internal static string MaxEntriesAttributeMustBeAPositiveInteger {
            get {
                return ResourceManager.GetString("MaxEntriesAttributeMustBeAPositiveInteger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MaxEntries must be a positive integer.
        /// </summary>
        internal static string MaxEntriesMustBePositiveInteger {
            get {
                return ResourceManager.GetString("MaxEntriesMustBePositiveInteger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine the authentication scheme to use with the default endpoint bindings..
        /// </summary>
        internal static string NoDefaultAuthScheme {
            get {
                return ResourceManager.GetString("NoDefaultAuthScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WCF RIA Service Traces.
        /// </summary>
        internal static string WCFTraceFeedTitle {
            get {
                return ResourceManager.GetString("WCFTraceFeedTitle", resourceCulture);
            }
        }
    }
}
