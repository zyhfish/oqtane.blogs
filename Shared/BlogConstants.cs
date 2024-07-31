﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oqtane.Blogs.Shared
{
    public sealed class BlogConstants
    {
        public const int DefaultVersion = 1;

        public const string DefaultSearchProperties = "Title,Summary";
        public const string DefaultSearchPosition = "Top";
        public const string DefaultSummaryTemplate = "<a href=\"[URL]\"><h2>[TITLE]</h2></a><p>[SUMMARY]</p>";
        public const string DefaultDetailTemplate = "<h2>[TITLE]</h2><p>[CONTENT]</p>";
        public const string DefaultColumnCssClass = "col-lg-4 col-md-6";
    }
}
