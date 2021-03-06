﻿using System.ComponentModel.DataAnnotations;
using Localization.Languages.Models.Shared;

namespace Topsite.Areas.Administration.Models.Categories
{
    public class BaseCategoryViewModel
    {
        [Display(ResourceType = typeof(Localization.Languages.Admin.Models.BaseCategoryViewModel), Name = "Name")]
        [Required(ErrorMessageResourceType = typeof(Shared), ErrorMessageResourceName = "Required")]
        [MaxLength(50, ErrorMessageResourceType = typeof(Shared), ErrorMessageResourceName = "MaximumLength")]
        public string Name { get; set; }

        [Display(ResourceType = typeof(Localization.Languages.Admin.Models.BaseCategoryViewModel), Name = "Keywords")]
        [MaxLength(250, ErrorMessageResourceType = typeof(Shared), ErrorMessageResourceName = "MaximumLength")]
        public string Keywords { get; set; }
    }
}