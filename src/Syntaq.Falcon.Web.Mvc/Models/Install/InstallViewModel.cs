﻿using System.Collections.Generic;
using Abp.Localization;
using FormBizz.Install.Dto;

namespace FormBizz.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
