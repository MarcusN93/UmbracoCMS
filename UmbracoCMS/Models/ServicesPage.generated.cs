//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
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
	/// <summary>Services Page</summary>
	[PublishedModel("servicesPage")]
	public partial class ServicesPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "servicesPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ServicesPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ServicesPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Contact - Background Image One
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactBackgroundImageOne")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ContactBackgroundImageOne => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "contactBackgroundImageOne");

		///<summary>
		/// Contact - Background Image Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactBackgroundImageTwo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ContactBackgroundImageTwo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "contactBackgroundImageTwo");

		///<summary>
		/// Contact - Box One Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactBoxOneText")]
		public virtual string ContactBoxOneText => this.Value<string>(_publishedValueFallback, "contactBoxOneText");

		///<summary>
		/// Contact - Box One Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactBoxOneTitle")]
		public virtual string ContactBoxOneTitle => this.Value<string>(_publishedValueFallback, "contactBoxOneTitle");

		///<summary>
		/// Contact - Box Three Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactBoxThreeText")]
		public virtual string ContactBoxThreeText => this.Value<string>(_publishedValueFallback, "contactBoxThreeText");

		///<summary>
		/// Contact - Box Three Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactBoxThreeTitle")]
		public virtual string ContactBoxThreeTitle => this.Value<string>(_publishedValueFallback, "contactBoxThreeTitle");

		///<summary>
		/// Contact - Box Two Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactBoxTwoText")]
		public virtual string ContactBoxTwoText => this.Value<string>(_publishedValueFallback, "contactBoxTwoText");

		///<summary>
		/// Contact - Box Two Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactBoxTwoTitle")]
		public virtual string ContactBoxTwoTitle => this.Value<string>(_publishedValueFallback, "contactBoxTwoTitle");

		///<summary>
		/// Contact - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactHeadline")]
		public virtual string ContactHeadline => this.Value<string>(_publishedValueFallback, "contactHeadline");

		///<summary>
		/// Contact - Main Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactMainImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ContactMainImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "contactMainImage");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Page Title - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitleHeadline")]
		public virtual string PageTitleHeadline => this.Value<string>(_publishedValueFallback, "pageTitleHeadline");

		///<summary>
		/// Services - Breadcrumb Current Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesBreadcrumbCurrentText")]
		public virtual string ServicesBreadcrumbCurrentText => this.Value<string>(_publishedValueFallback, "servicesBreadcrumbCurrentText");

		///<summary>
		/// Services - Breadcrumb Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesBreadcrumbText")]
		public virtual string ServicesBreadcrumbText => this.Value<string>(_publishedValueFallback, "servicesBreadcrumbText");

		///<summary>
		/// Services - Breadcrumb Url
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesBreadcrumbUrl")]
		public virtual string ServicesBreadcrumbUrl => this.Value<string>(_publishedValueFallback, "servicesBreadcrumbUrl");

		///<summary>
		/// Services - Card Five Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardFiveImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServicesCardFiveImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "servicesCardFiveImage");

		///<summary>
		/// Services - Card Five Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardFiveText")]
		public virtual string ServicesCardFiveText => this.Value<string>(_publishedValueFallback, "servicesCardFiveText");

		///<summary>
		/// Services - Card Five Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardFiveTitle")]
		public virtual string ServicesCardFiveTitle => this.Value<string>(_publishedValueFallback, "servicesCardFiveTitle");

		///<summary>
		/// Services - Card Four Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardFourImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServicesCardFourImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "servicesCardFourImage");

		///<summary>
		/// Services - Card Four Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardFourText")]
		public virtual string ServicesCardFourText => this.Value<string>(_publishedValueFallback, "servicesCardFourText");

		///<summary>
		/// Services - Card Four Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardFourTitle")]
		public virtual string ServicesCardFourTitle => this.Value<string>(_publishedValueFallback, "servicesCardFourTitle");

		///<summary>
		/// Services - Card One Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardOneImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServicesCardOneImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "servicesCardOneImage");

		///<summary>
		/// Services - Card One Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardOneText")]
		public virtual string ServicesCardOneText => this.Value<string>(_publishedValueFallback, "servicesCardOneText");

		///<summary>
		/// Services - Card One Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardOneTitle")]
		public virtual string ServicesCardOneTitle => this.Value<string>(_publishedValueFallback, "servicesCardOneTitle");

		///<summary>
		/// Services - Card Six Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardSixImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServicesCardSixImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "servicesCardSixImage");

		///<summary>
		/// Services - Card Six Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardSixText")]
		public virtual string ServicesCardSixText => this.Value<string>(_publishedValueFallback, "servicesCardSixText");

		///<summary>
		/// Services - Card Six Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardSixTitle")]
		public virtual string ServicesCardSixTitle => this.Value<string>(_publishedValueFallback, "servicesCardSixTitle");

		///<summary>
		/// Services - Card Three Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardThreeImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServicesCardThreeImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "servicesCardThreeImage");

		///<summary>
		/// Services - Card Three Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardThreeText")]
		public virtual string ServicesCardThreeText => this.Value<string>(_publishedValueFallback, "servicesCardThreeText");

		///<summary>
		/// Services - Card Three Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardThreeTitle")]
		public virtual string ServicesCardThreeTitle => this.Value<string>(_publishedValueFallback, "servicesCardThreeTitle");

		///<summary>
		/// Services - Card Two Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardTwoImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServicesCardTwoImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "servicesCardTwoImage");

		///<summary>
		/// Services - Card Two Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardTwoText")]
		public virtual string ServicesCardTwoText => this.Value<string>(_publishedValueFallback, "servicesCardTwoText");

		///<summary>
		/// Services - Card Two Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesCardTwoTitle")]
		public virtual string ServicesCardTwoTitle => this.Value<string>(_publishedValueFallback, "servicesCardTwoTitle");

		///<summary>
		/// Services - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesHeadline")]
		public virtual string ServicesHeadline => this.Value<string>(_publishedValueFallback, "servicesHeadline");
	}
}
