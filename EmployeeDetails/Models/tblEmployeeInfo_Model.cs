﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeDetails.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class tblEmployeeInfo_Model
    {
        [StringLength(50)]
        public string EmpId { get; set; }
        [StringLength(50)]
        public string EmpName { get; set; }
        public Nullable<int> EmpContact { get; set; }

        [StringLength(50)] 
        public string EmpAddress { get; set; }
        [StringLength(50)]
        public string EmpDept { get; set; }
    }
}
