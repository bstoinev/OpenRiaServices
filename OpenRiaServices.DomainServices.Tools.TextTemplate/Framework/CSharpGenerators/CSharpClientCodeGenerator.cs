﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace OpenRiaServices.DomainServices.Tools.TextTemplate.CSharpGenerators
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class CSharpClientCodeGenerator : OpenRiaServices.DomainServices.Tools.TextTemplate.ClientCodeGenerator
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
 this.GenerateProxyClass(); 
            return this.GenerationEnvironment.ToString();
        }
    }
}
