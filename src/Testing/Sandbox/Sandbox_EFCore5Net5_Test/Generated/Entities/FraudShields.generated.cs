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
   public partial class FraudShields
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected FraudShields()
      {
         // NOTE: This class has one-to-one associations with FraudShields.
         // One-to-one associations are not validated in constructors since this causes a scenario where each one must be constructed before the other.

         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static FraudShields CreateFraudShieldsUnsafe()
      {
         return new FraudShields();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="fraudshieldid"></param>
      /// <param name="creditprofileid">Foreign key for CreditProfiles.FraudShields &lt;--&gt; FraudShields.CreditProfile. </param>
      /// <param name="creditprofile"></param>
      public FraudShields(Guid fraudshieldid, Guid creditprofileid, global::Credit.API.Domain_RE.Models_RE.CreditProfiles creditprofile)
      {
         // NOTE: This class has one-to-one associations with FraudShields.
         // One-to-one associations are not validated in constructors since this causes a scenario where each one must be constructed before the other.

         this.FraudShieldId = fraudshieldid;

         this.CreditProfileId = creditprofileid;

         if (creditprofile == null) throw new ArgumentNullException(nameof(creditprofile));
         this.CreditProfile = creditprofile;
         creditprofile.FraudShields.Add(this);

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="fraudshieldid"></param>
      /// <param name="creditprofileid">Foreign key for CreditProfiles.FraudShields &lt;--&gt; FraudShields.CreditProfile. </param>
      /// <param name="creditprofile"></param>
      public static FraudShields Create(Guid fraudshieldid, Guid creditprofileid, global::Credit.API.Domain_RE.Models_RE.CreditProfiles creditprofile)
      {
         return new FraudShields(fraudshieldid, creditprofileid, creditprofile);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Max length = 6
      /// </summary>
      [MaxLength(6)]
      [StringLength(6)]
      public string AddressCount { get; set; }

      /// <summary>
      /// Max length = 12
      /// </summary>
      [MaxLength(12)]
      [StringLength(12)]
      public string AddressDate { get; set; }

      /// <summary>
      /// Max length = 3
      /// </summary>
      [MaxLength(3)]
      [StringLength(3)]
      public string AddressErrorCode { get; set; }

      /// <summary>
      /// Indexed, Required
      /// Foreign key for CreditProfiles.FraudShields &lt;--&gt; FraudShields.CreditProfile. 
      /// </summary>
      [Required]
      [System.ComponentModel.Description("Foreign key for CreditProfiles.FraudShields <--> FraudShields.CreditProfile. ")]
      public Guid CreditProfileId { get; set; }

      /// <summary>
      /// Max length = 12
      /// </summary>
      [MaxLength(12)]
      [StringLength(12)]
      public string DateOfBirth { get; set; }

      /// <summary>
      /// Max length = 12
      /// </summary>
      [MaxLength(12)]
      [StringLength(12)]
      public string DateOfDeath { get; set; }

      /// <summary>
      /// Identity, Required
      /// </summary>
      [Key]
      [Required]
      public Guid FraudShieldId { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string Sic { get; set; }

      /// <summary>
      /// Max length = 5
      /// </summary>
      [MaxLength(5)]
      [StringLength(5)]
      public string SocialCount { get; set; }

      /// <summary>
      /// Max length = 12
      /// </summary>
      [MaxLength(12)]
      [StringLength(12)]
      public string SocialDate { get; set; }

      /// <summary>
      /// Max length = 5
      /// </summary>
      [MaxLength(5)]
      [StringLength(5)]
      public string SocialErrorCode { get; set; }

      /// <summary>
      /// Max length = 4
      /// </summary>
      [MaxLength(4)]
      [StringLength(4)]
      public string SsnFirstPossibleIssuanceYear { get; set; }

      /// <summary>
      /// Max length = 4
      /// </summary>
      [MaxLength(4)]
      [StringLength(4)]
      public string SsnLastPossibleIssuanceYear { get; set; }

      /// <summary>
      /// Max length = 150
      /// </summary>
      [MaxLength(150)]
      [StringLength(150)]
      public string Text { get; set; }

      /// <summary>
      /// Max length = 4
      /// </summary>
      [MaxLength(4)]
      [StringLength(4)]
      public string Type { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Credit.API.Domain_RE.Models_RE.CreditProfiles CreditProfile { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Credit.API.Domain_RE.Models_RE.FraudShieldIndicators FraudShieldIndicators { get; set; }

   }
}

