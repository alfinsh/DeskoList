//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThemeOpenUpdates
    {
        public int Id { get; set; }
        public int ThemeId { get; set; }
        public string DownloadPath { get; set; }
        public string Version { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDownloaded { get; set; }
        public string DownloadUrl { get; set; }
        public string DeskoVersion { get; set; }
    
        public virtual Themes Themes { get; set; }
    }
}
