using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// ������
    /// </summary>
    public partial class pl_article_attach : BaseEntity<int>
    {
        /// <summary>
        /// ����ID
        /// </summary>
        public Nullable<int> article_id { get; set; }

        /// <summary>
        /// �ļ���
        /// </summary>
        public string file_name { get; set; }

        /// <summary>
        /// �ļ�·��
        /// </summary>
        public string file_path { get; set; }

        /// <summary>
        /// �ļ���С(�ֽ�)
        /// </summary>
        public Nullable<int> file_size { get; set; }

        /// <summary>
        /// �ļ���չ��
        /// </summary>
        public string file_ext { get; set; }
        /// <summary>
        /// ���ش���
        /// </summary>
        public Nullable<int> down_num { get; set; }

        /// <summary>
        /// ����(��:����;��:����)
        /// </summary>
        public Nullable<int> point { get; set; }
    }
}
