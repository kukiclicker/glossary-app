//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Glossary
    {
        [NotMapped]
        public int TermID { get; set; }
        public string Term { get; set; }
        public string Definition { get; set; }

        public Glossary(string term, string definition)
        {
            TermID = 0;
            Term = term;
            Definition = definition;
        }
        public Glossary()
        {
            
        }
    }
}
