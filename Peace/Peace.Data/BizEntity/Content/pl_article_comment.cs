using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// �������۱�
    /// </summary>
    public partial class pl_article_comment : BaseEntity<int>
    {
        /// <summary>
        /// Ƶ��ID
        /// </summary>
        public Nullable<int> channel_id { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public Nullable<int> article_id { get; set; }

        /// <summary>
        /// ������ID
        /// </summary>
        public Nullable<int> parent_id { get; set; }

        /// <summary>
        /// �û�ID
        /// </summary>
        public Nullable<int> user_id { get; set; }

        /// <summary>
        /// �û���
        /// </summary>
        public string user_name { get; set; }

        /// <summary>
        /// �û�IP
        /// </summary>
        public string user_ip { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public Nullable<byte> is_lock { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public Nullable<System.DateTime> add_time { get; set; }

        /// <summary>
        /// �Ƿ��Ѵ�
        /// </summary>
        public Nullable<byte> is_reply { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string reply_content { get; set; }

        /// <summary>
        /// �ظ�ʱ��
        /// </summary>
        public Nullable<System.DateTime> reply_time { get; set; }
    }
}
