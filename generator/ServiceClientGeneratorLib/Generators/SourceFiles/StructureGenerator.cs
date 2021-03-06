﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class StructureGenerator : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Xml.Serialization;" +
                    "\r\nusing System.Text;\r\nusing System.IO;\r\n\r\nusing Amazon.Runtime;\r\nusing Amazon.Ru" +
                    "ntime.Internal;\r\n");
            
            #line 17 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

if(this.StructureType == StructureType.Request && this.Operation.AuthType.HasValue)
{

            
            #line default
            #line hidden
            this.Write("using Amazon.Runtime.Internal.Auth;\r\n");
            
            #line 22 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

}

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 26 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model\r\n{\r\n");
            
            #line 28 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

	if(this.StructureType == StructureType.Request)
		this.FormatOperationRequestDocumentation(this.Operation);
	else if (this.Operation != null && GeneratorHelpers.HasSuppressedResult(this.Operation))
		this.FormatVoidResultDocumentation(this.Operation.Name);
	else if(this.StructureType == StructureType.Response && (this.Structure == null || string.IsNullOrEmpty(this.Structure.Documentation)))
	{

            
            #line default
            #line hidden
            this.Write("\t/// <summary>\r\n\t/// This is the response object from the ");
            
            #line 37 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write(" operation.\r\n\t/// </summary>\r\n");
            
            #line 39 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

	}
	else
	    this.FormatClassDocumentation(this.Structure);  

            
            #line default
            #line hidden
            
            #line 44 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
		
		if(this.Structure != null && this.Structure.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("    [Obsolete(\"");
            
            #line 48 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 49 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

		}

            
            #line default
            #line hidden
            this.Write("\tpublic partial class ");
            
            #line 52 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ClassName));
            
            #line default
            #line hidden
            
            #line 52 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.BaseClassString));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 54 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

        if(this.Structure != null)
        {
            if(this.IsWrapped)
            {

            
            #line default
            #line hidden
            this.Write("        private ");
            
            #line 60 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" _response;\r\n");
            
            #line 61 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

            }
            else
            {
		        foreach(var member in this.Structure.Members)
                {
					if (member.IsExcluded)
						continue;

            
            #line default
            #line hidden
            this.Write("        private ");
            
            #line 70 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            
            #line 70 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.IsNullable ? "?" : ""));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 70 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            
            #line 70 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.ShouldInstantiate ? string.Format(" = new {0}();", member.DetermineType()) : ";"));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 71 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 77 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

        if(this.Structure != null)
        {
            if(this.IsWrapped)
            {

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Gets and sets the ");
            
            #line 84 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" property.\r\n        /// </summary>\r\n");
            
            #line 86 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
		
				if(this.Structure.IsDeprecated)
				{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 90 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 91 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

				}

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 94 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 94 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get { return this._response; }\r\n            set { this._" +
                    "response = value; }\r\n        }\r\n");
            
            #line 99 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

            }
            else
            {
        AddSimpleRequestConstructors(this.ClassName, this.Structure, this.Config.Namespace);
		        foreach(var member in this.Structure.Members)
                {
					if (member.IsExcluded)
						continue;

            
            #line default
            #line hidden
            
            #line 109 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
 this.FormatPropertyDocumentation(member); 
            
            #line default
            #line hidden
            
            #line 110 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
		
					if(member.IsDeprecated)
					{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 114 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 115 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

					}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 118 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.AccessModifier));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 118 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            
            #line 118 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.UseNullable ? "?" : ""));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 118 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n");
            
            #line 120 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    if(member.IsNullable && !member.UseNullable)
                    {

            
            #line default
            #line hidden
            this.Write("            get { return this.");
            
            #line 124 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".GetValueOrDefault(); }\r\n");
            
            #line 125 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else
                    {

            
            #line default
            #line hidden
            this.Write("            get { return this.");
            
            #line 130 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write("; }\r\n");
            
            #line 131 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("            set { this.");
            
            #line 134 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" = value; }\r\n        }\r\n\r\n");
            
            #line 137 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    if (member.EmitIsSetProperties)
                    {

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// This property is set to true if the property <" +
                    "seealso cref=\"");
            
            #line 142 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(@"""/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
");
            
            #line 151 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
		
						if(member.IsDeprecated)
						{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 155 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 156 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

						}

            
            #line default
            #line hidden
            this.Write("        public bool Is");
            
            #line 159 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("Set\r\n        {\r\n            get\r\n            {\r\n                return Amazon.Uti" +
                    "l.Internal.InternalSDKUtils.GetIsSet(this.");
            
            #line 163 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(");\r\n            }\r\n            set\r\n            {\r\n                Amazon.Util.In" +
                    "ternal.InternalSDKUtils.SetIsSet(value, ref this.");
            
            #line 167 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(");\r\n            }\r\n        }\r\n\r\n");
            
            #line 171 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("        // Check to see if ");
            
            #line 174 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" property is set\r\n        internal bool IsSet");
            
            #line 175 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n");
            
            #line 177 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    if (member.EmitIsSetProperties)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.Is");
            
            #line 181 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("Set; \r\n");
            
            #line 182 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else if (member.IsNullable)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 187 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".HasValue; \r\n");
            
            #line 188 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else if (member.IsMap || member.IsList)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 193 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" != null && this.");
            
            #line 193 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".Count > 0; \r\n");
            
            #line 194 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 199 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" != null;\r\n");
            
            #line 200 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 205 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                }

                if (this.StructureType == StructureType.Request && this.Operation.AuthType.HasValue)
                {

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Get the signer to use for this request.\r\n     " +
                    "   /// </summary>\r\n        /// <returns>A signer for this request.</returns>\r\n  " +
                    "      override protected AbstractAWSSigner CreateSigner()\r\n        {\r\n");
            
            #line 217 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    switch (this.Operation.AuthType.Value)
                    {
                        case OperationAuthType.None:

            
            #line default
            #line hidden
            this.Write("            return new NullSigner();\r\n");
            
            #line 223 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                        break;
                        case OperationAuthType.V4:

            
            #line default
            #line hidden
            this.Write("            return new AWS4Signer();\r\n");
            
            #line 228 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                        break;
                        case OperationAuthType.V4UnsignedBody:

            
            #line default
            #line hidden
            this.Write("            return new AWS4Signer(false);\r\n");
            
            #line 233 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                        break;
                        default:
                            throw new ArgumentException("Unhandled value for operation authtype:" + this.Operation.AuthType.Value);
                    }

            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 240 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                }

            }
        }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 250 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

    // Set to true when the service model specifies a shape that should be wrapped in a response. ElastiCache CreateCacheCluster is an example of this.
    public bool IsWrapped { get; set; }

	public Operation Operation { get; set; }
    public string ClassName { get; set; }
    public string BaseClass { get; set; }
    public Shape Structure { get; set; }
	public StructureType StructureType { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
