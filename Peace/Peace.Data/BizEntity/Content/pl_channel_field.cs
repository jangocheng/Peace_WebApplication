using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// Ƶ�����Ա�
    /// </summary>
    public partial class pl_channel_field : BaseEntity<int>
    {
        /// <summary>
        /// Ƶ��ID
        /// </summary>
        public Nullable<int> channel_id { get; set; }

        /// <summary>
        /// �ֶ�ID
        /// </summary>
        public Nullable<int> field_id { get; set; }
    }
}
