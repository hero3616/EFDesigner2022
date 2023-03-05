//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v4.2.3.2
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Credit.API.Domain_RE.Models_RE
{
   public partial class EnhancedPaymentDatas
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected EnhancedPaymentDatas()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static EnhancedPaymentDatas CreateEnhancedPaymentDatasUnsafe()
      {
         return new EnhancedPaymentDatas();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="enhancedpaymentdataid"></param>
      /// <param name="trendedtradelineid">Foreign key for EnhancedPaymentDatas.TrendedTradeLine &lt;--&gt; TrendedTradeLines.EnhancedPaymentDatas.</param>
      public EnhancedPaymentDatas(Guid enhancedpaymentdataid, Guid trendedtradelineid)
      {
         this.EnhancedPaymentDataId = enhancedpaymentdataid;

         this.TrendedTradeLineId = trendedtradelineid;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="enhancedpaymentdataid"></param>
      /// <param name="trendedtradelineid">Foreign key for EnhancedPaymentDatas.TrendedTradeLine &lt;--&gt; TrendedTradeLines.EnhancedPaymentDatas.</param>
      public static EnhancedPaymentDatas Create(Guid enhancedpaymentdataid, Guid trendedtradelineid)
      {
         return new EnhancedPaymentDatas(enhancedpaymentdataid, trendedtradelineid);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string ActualPaymentAmount { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string ChargeOffAmount { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string CiiCode { get; set; }

      /// <summary>
      /// Max length = 100
      /// </summary>
      [MaxLength(100)]
      [StringLength(100)]
      public string ComplianceCondition { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string CreditLimitAmount { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string EnhancedAccountCondition { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string EnhancedAccountType { get; set; }

      /// <summary>
      /// Identity, Required
      /// </summary>
      [Key]
      [Required]
      public Guid EnhancedPaymentDataId { get; set; }

      /// <summary>
      /// Max length = 100
      /// </summary>
      [MaxLength(100)]
      [StringLength(100)]
      public string EnhancedPaymentHistory84 { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string EnhancedPaymentStatus { get; set; }

      /// <summary>
      /// Max length = 500
      /// </summary>
      [MaxLength(500)]
      [StringLength(500)]
      public string EnhancedSpecialComment { get; set; }

      /// <summary>
      /// Max length = 50
      /// </summary>
      [MaxLength(50)]
      [StringLength(50)]
      public string EnhancedTerms { get; set; }

      /// <summary>
      /// Max length = 50
      /// </summary>
      [MaxLength(50)]
      [StringLength(50)]
      public string EnhancedTermsFrequency { get; set; }

      /// <summary>
      /// Max length = 12
      /// </summary>
      [MaxLength(12)]
      [StringLength(12)]
      public string FirstDelinquencyDate { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string HighBalanceAmount { get; set; }

      /// <summary>
      /// Max length = 50
      /// </summary>
      [MaxLength(50)]
      [StringLength(50)]
      public string MaxDelinquencyCode { get; set; }

      /// <summary>
      /// Max length = 50
      /// </summary>
      [MaxLength(50)]
      [StringLength(50)]
      public string MortgageId { get; set; }

      /// <summary>
      /// Max length = 50
      /// </summary>
      [MaxLength(50)]
      [StringLength(50)]
      public string OriginalCreditorClassificationCode { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string OriginalLoanAmount { get; set; }

      /// <summary>
      /// Max length = 12
      /// </summary>
      [MaxLength(12)]
      [StringLength(12)]
      public string PaymentLevelDate { get; set; }

      /// <summary>
      /// Max length = 100
      /// </summary>
      [MaxLength(100)]
      [StringLength(100)]
      public string PurchasedPortfolioFromName { get; set; }

      /// <summary>
      /// Max length = 50
      /// </summary>
      [MaxLength(50)]
      [StringLength(50)]
      public string SecondaryAgencyCode { get; set; }

      /// <summary>
      /// Max length = 50
      /// </summary>
      [MaxLength(50)]
      [StringLength(50)]
      public string SecondaryAgencyId { get; set; }

      /// <summary>
      /// Max length = 12
      /// </summary>
      [MaxLength(12)]
      [StringLength(12)]
      public string SecondDelinquencyDate { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string SpecialPaymentAmount { get; set; }

      /// <summary>
      /// Max length = 5
      /// </summary>
      [MaxLength(5)]
      [StringLength(5)]
      public string SpecialPaymentCode { get; set; }

      /// <summary>
      /// Max length = 12
      /// </summary>
      [MaxLength(12)]
      [StringLength(12)]
      public string SpecialPaymentDate { get; set; }

      /// <summary>
      /// Indexed, Required
      /// Foreign key for EnhancedPaymentDatas.TrendedTradeLine &lt;--&gt; TrendedTradeLines.EnhancedPaymentDatas.
      /// </summary>
      [Required]
      [System.ComponentModel.Description("Foreign key for EnhancedPaymentDatas.TrendedTradeLine <--> TrendedTradeLines.EnhancedPaymentDatas. ")]
      public Guid TrendedTradeLineId { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Credit.API.Domain_RE.Models_RE.TrendedTradeLines TrendedTradeLine { get; set; }

   }
}

