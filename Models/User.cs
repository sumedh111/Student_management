//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Student_management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int User_Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public byte[] User_Password { get; set; }
    }
}