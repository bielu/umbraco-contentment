//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.0.0-rc1+890da5f
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Test Misc Page</summary>
	[PublishedModel("testMiscPage")]
	public partial class TestMiscPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		public new const string ModelTypeAlias = "testMiscPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<TestMiscPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public TestMiscPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Data List Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListItems")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Community.Contentment.DataEditors.DataListItem> DataListItems => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Community.Contentment.DataEditors.DataListItem>>(_publishedValueFallback, "dataListItems");

		///<summary>
		/// Data Picker - Umbraco Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataPickerUmbracoContent")]
		public virtual global::System.Collections.Generic.List<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent> DataPickerUmbracoContent => this.Value<global::System.Collections.Generic.List<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>>(_publishedValueFallback, "dataPickerUmbracoContent");

		///<summary>
		/// Icon Picker
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("iconPicker")]
		public virtual string IconPicker => this.Value<string>(_publishedValueFallback, "iconPicker");

		///<summary>
		/// Icon Picker Small
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("iconPickerSmall")]
		public virtual string IconPickerSmall => this.Value<string>(_publishedValueFallback, "iconPickerSmall");

		///<summary>
		/// Social Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("socialLinks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.SocialLink> SocialLinks => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.SocialLink>>(_publishedValueFallback, "socialLinks");

		///<summary>
		/// Test Textbox: Used as a guide/comparison for the Textbox List editor.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("testTextbox")]
		public virtual string TestTextbox => this.Value<string>(_publishedValueFallback, "testTextbox");

		///<summary>
		/// Textbox List
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textboxList")]
		public virtual global::System.Collections.Specialized.NameValueCollection TextboxList => this.Value<global::System.Collections.Specialized.NameValueCollection>(_publishedValueFallback, "textboxList");

		///<summary>
		/// Text Input
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textInput")]
		public virtual string TextInput => this.Value<string>(_publishedValueFallback, "textInput");

		///<summary>
		/// Text Input Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.0-rc1+890da5f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textInputEmail")]
		public virtual string TextInputEmail => this.Value<string>(_publishedValueFallback, "textInputEmail");
	}
}
