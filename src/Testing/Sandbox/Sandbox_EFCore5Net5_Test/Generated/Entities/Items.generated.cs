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
   public partial class Items
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Items()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static Items CreateItemsUnsafe()
      {
         return new Items();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="itemid"></param>
      /// <param name="fraudshieldindicatorsid">Foreign key for FraudShieldIndicators.Items &lt;--&gt; Items.FraudShieldIndicators. </param>
      /// <param name="fraudshieldindicators"></param>
      public Items(Guid itemid, Guid fraudshieldindicatorsid, global::Credit.API.Domain_RE.Models_RE.FraudShieldIndicators fraudshieldindicators)
      {
         this.ItemId = itemid;

         this.FraudShieldIndicatorsId = fraudshieldindicatorsid;

         if (fraudshieldindicators == null) throw new ArgumentNullException(nameof(fraudshieldindicators));
         this.FraudShieldIndicators = fraudshieldindicators;
         fraudshieldindicators.Items.Add(this);

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="itemid"></param>
      /// <param name="fraudshieldindicatorsid">Foreign key for FraudShieldIndicators.Items &lt;--&gt; Items.FraudShieldIndicators. </param>
      /// <param name="fraudshieldindicators"></param>
      public static Items Create(Guid itemid, Guid fraudshieldindicatorsid, global::Credit.API.Domain_RE.Models_RE.FraudShieldIndicators fraudshieldindicators)
      {
         return new Items(itemid, fraudshieldindicatorsid, fraudshieldindicators);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Indexed, Required
      /// Foreign key for FraudShieldIndicators.Items &lt;--&gt; Items.FraudShieldIndicators. 
      /// </summary>
      [Required]
      [System.ComponentModel.Description("Foreign key for FraudShieldIndicators.Items <--> Items.FraudShieldIndicators. ")]
      public Guid FraudShieldIndicatorsId { get; set; }

      /// <summary>
      /// Identity, Required
      /// </summary>
      [Key]
      [Required]
      public Guid ItemId { get; set; }

      /// <summary>
      /// Max length = 500
      /// </summary>
      [MaxLength(500)]
      [StringLength(500)]
      public string Items1 { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Credit.API.Domain_RE.Models_RE.FraudShieldIndicators FraudShieldIndicators { get; set; }

   }
}

