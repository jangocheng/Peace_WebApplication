using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// ͼƬ���
    /// </summary>
    public partial class pl_article_albums:BaseEntity<int>
    {
        /// <summary>
        /// ����ID
        /// </summary>
        public Nullable<int> article_id { get; set; }

        /// <summary>
        /// ����ͼ��ַ
        /// </summary>
        public string thumb_path { get; set; }

        /// <summary>
        /// ԭͼ��ַ
        /// </summary>
        public string original_path { get; set; }

        /// <summary>
        /// ͼƬ����
        /// </summary>
        public string remark { get; set; }
    }
}
