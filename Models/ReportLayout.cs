using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ReportLayout
    {
        public string ReportName { get; set; }
        public string FieldName { get; set; }
        public string FieldText { get; set; }
        public string FieldFont { get; set; }
        public decimal? FontSize { get; set; }
        public string FontUnderline { get; set; }
        public string FontItalic { get; set; }
        public string FontBold { get; set; }
        public decimal? FontColor { get; set; }
        public string Dept { get; set; }
        public string Company { get; set; }
    }
}
