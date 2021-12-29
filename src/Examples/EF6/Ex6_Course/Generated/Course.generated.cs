//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v3.0.7.2
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

namespace Ex5_Course
{
   public partial class Course
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public Course()
      {
         Enrollments = new System.Collections.Generic.HashSet<global::Ex5_Course.Enrollment>();

         Init();
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Identity, Required
      /// </summary>
      [Key]
      [Required]
      public long CourseId { get; set; }

      /// <summary>
      /// Max length = 25
      /// </summary>
      [MaxLength(25)]
      [StringLength(25)]
      public string CourseLabel { get; set; }

      public string Title { get; set; }

      public int? Credits { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      public virtual ICollection<global::Ex5_Course.Enrollment> Enrollments { get; private set; }

   }
}

