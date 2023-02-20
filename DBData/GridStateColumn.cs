using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class GridStateColumn
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public int? ColumnIndex { get; set; }
        public string? ColumnName { get; set; }
        public string? Width { get; set; }
        public bool IsVisible { get; set; }
        public string? FilterValue { get; set; }
        public string? DataType { get; set; }
        public string? SortOrder { get; set; }
        public int? SortIndex { get; set; }
        public string? HeadFilterValues { get; set; }
        public int? GroupIndex { get; set; }
        public string? FilterType { get; set; }
        public string? SelectedFilterOperation { get; set; }

        public virtual GridStateProfile Profile { get; set; } = null!;
    }
}
