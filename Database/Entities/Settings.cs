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
    
    public partial class Settings
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public int ShowAmountWebsites { get; set; }
        public bool Maintenance { get; set; }
        public string Version { get; set; }
        public string SiteTitle { get; set; }
        public string SiteSlogan { get; set; }
        public bool IsEmailVerificationRequired { get; set; }
        public string Url { get; set; }
        public string CronjobUserStatisticsEmail { get; set; }
        public string Footer { get; set; }
        public bool IsPingEnabled { get; set; }
        public int ThemeId { get; set; }
        public string CronjobInAndOut { get; set; }
        public string RecaptchaSecretKey { get; set; }
        public string RecaptchaSiteKey { get; set; }
        public string CronWebsiteThumbnail { get; set; }
        public bool IsCreateThumbnailsEnabled { get; set; }
        public string CronPingServer { get; set; }
        public string CronUpdate { get; set; }
        public bool UpdateWhenIncorrectVersion { get; set; }
        public bool AutoUpdate { get; set; }
        public bool IsEmailingUserStatisticsEnabled { get; set; }
        public bool IsResetInAndOutsEnabled { get; set; }
        public int LanguageId { get; set; }
        public string Timezone { get; set; }
        public bool IsAdminVerificationRequired { get; set; }
    
        public virtual Languages Languages { get; set; }
        public virtual Themes Themes { get; set; }
    }
}