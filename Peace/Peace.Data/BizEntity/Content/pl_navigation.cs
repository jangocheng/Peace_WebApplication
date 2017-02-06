using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// ϵͳ�����˵�
    /// </summary>
    public partial class pl_navigation : BaseEntity<int>
    {
        /// <summary>
        /// ����������ID
        /// </summary>
        public Nullable<int> parent_id { get; set; }

        /// <summary>
        /// ����Ƶ��ID
        /// </summary>
        public Nullable<int> channel_id { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public string nav_type { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string sub_title { get; set; }

        /// <summary>
        ///    ͼ���ַ 
        /// </summary>
        public string icon_url { get; set; }

        /// <summary>
        /// ���ӵ�ַ
        /// </summary>
        public string link_url { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Nullable<int> sort_id { get; set; }

        /// <summary>
        /// �Ƿ�����0��ʾ1����
        /// </summary>
        public Nullable<byte> is_lock { get; set; }

        /// <summary>
        /// ��ע˵��
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// Ȩ����Դ
        /// </summary>
        public string action_type { get; set; }

        /// <summary>
        /// ϵͳĬ��
        /// </summary>
        public Nullable<byte> is_sys { get; set; }
    }
}
