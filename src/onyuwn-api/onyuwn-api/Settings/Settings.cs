﻿using System;
using System.Collections.Generic;
using System.Text;

namespace onyuwn_api.Settings
{
    public static class AppSettings
    {
        public static string ApiKey { get; set; } = Environment.GetEnvironmentVariable("APIKey");
    }
}
