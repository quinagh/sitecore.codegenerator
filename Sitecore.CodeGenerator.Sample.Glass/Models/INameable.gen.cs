﻿// <autogenerated>
//   This file was generated by T4 code generator SampleScriptTemplates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>



using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using global::Glass.Mapper.Sc.Configuration;
using global::Glass.Mapper.Sc.Configuration.Attributes;
using global::Glass.Mapper.Sc.Fields;

namespace Sitecore.CodeGenerator.Sample.Glass.Models
{
	
	/// <summary>
	/// Represents a mapped type for item {2852DE45-BF36-44D8-9435-8A30EC6923C5} in Sitecore.
	/// Path: /sitecore/templates/Sitecore Code Generator Sample/Nameable
	/// </summary>
	[SitecoreType(TemplateId = "{2852DE45-BF36-44D8-9435-8A30EC6923C5}")]
	public partial interface INameable
	{
		#region Name

	    [SitecoreField(FieldId = "{7E4FAA48-E6CE-46B7-888E-309B5FCC4107}")]
		string Name { get; set; }

		#endregion

	}
}
