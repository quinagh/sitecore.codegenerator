﻿// <autogenerated>
//   This file was generated by T4 code generator SampleScriptTemplates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

namespace Sitecore.CodeGenerator.Sample.Glass.Models
{
	using System;
    using System.Collections.Generic;
	using System.Collections.Specialized;
    using global::Glass.Mapper.Sc.Configuration;
    using global::Glass.Mapper.Sc.Configuration.Attributes;
	using global::Glass.Mapper.Sc.Fields;

	/// <summary>
	/// Represents a mapped type for item {F4A0D5D5-49F9-488F-82AA-D4BE1ADCB662} in Sitecore.
	/// Path: /sitecore/templates/Sitecore Code Generator Sample/Dog
	/// </summary>
	[SitecoreType(TemplateId = "{F4A0D5D5-49F9-488F-82AA-D4BE1ADCB662}")]
	public partial interface IDog : IAnimal, INameable
	{
		#region Dog

		/// <summary>
		/// What food does the dog eat?
		/// </summary>
	    [SitecoreField(FieldId = "{1033D7C1-9C1A-4C65-8316-81B6D5E46EB5}")]
		IEnumerable<IFood> Eats { get; set; }

		/// <summary>
		/// Other dogs that this dog likes
		/// </summary>
	    [SitecoreField(FieldId = "{20D7789D-BCE0-473E-BB46-59B216CE2C10}", Setting = SitecoreFieldSettings.DontLoadLazily)]
		IEnumerable<IDog> Friends { get; set; }

		#endregion

	}
}
