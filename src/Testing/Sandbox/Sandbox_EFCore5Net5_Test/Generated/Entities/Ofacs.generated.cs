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
   public partial class Ofacs
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Ofacs()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static Ofacs CreateOfacsUnsafe()
      {
         return new Ofacs();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="ofacid"></param>
      /// <param name="creditprofileid"></param>
      public Ofacs(Guid ofacid, Guid creditprofileid)
      {
         this.OfacId = ofacid;

         this.CreditProfileId = creditprofileid;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="ofacid"></param>
      /// <param name="creditprofileid"></param>
      public static Ofacs Create(Guid ofacid, Guid creditprofileid)
      {
         return new Ofacs(ofacid, creditprofileid);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Indexed, Required
      /// </summary>
      [Required]
      public Guid CreditProfileId { get; set; }

      /// <summary>
      /// Max length = 6
      /// </summary>
      [MaxLength(6)]
      [StringLength(6)]
      public string MessageNumber { get; set; }

      /// <summary>
      /// Max length = 100
      /// </summary>
      [MaxLength(100)]
      [StringLength(100)]
      public string MessageText { get; set; }

      /// <summary>
      /// Identity, Required
      /// </summary>
      [Key]
      [Required]
      public Guid OfacId { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Credit.API.Domain_RE.Models_RE.CreditProfiles CreditProfile { get; set; }

   }
}

