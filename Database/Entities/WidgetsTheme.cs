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
    
    public partial class WidgetsTheme
    {
        public int Id { get; set; }
        public int WidgetId { get; set; }
        public int ThemeSectionId { get; set; }
        public int Order { get; set; }
        public bool IsEnabled { get; set; }
    
        public virtual Widgets Widgets { get; set; }
        public virtual WidgetsThemeSection WidgetsThemeSection { get; set; }
    }
}