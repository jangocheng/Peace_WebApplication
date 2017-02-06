﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peace.Data
{
    public static class SystemUserRoleNames
    {
        public static string Administrators { get { return "Administrators"; } }

        //   public static string ForumModerators { get { return "ForumModerators"; } }

        public static string Registered { get { return "Registered"; } }

        public static string Guests { get { return "Guests"; } }

        public static string Admin { get { return "Admin"; } }

        public static string Employeer { get { return "Employeer"; } }
    }
    /// <summary>
    /// 系统用户名称  
    /// </summary>
    public static class SystemUserNames
    {
        public static string SearchEngine { get { return "SearchEngine"; } }
        public static string BackgroundTask { get { return "BackgroundTask"; } }
    }
}
