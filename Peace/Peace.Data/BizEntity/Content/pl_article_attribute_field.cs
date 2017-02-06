using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// ��չ���Ա�
    /// </summary>
    public partial class pl_article_attribute_field : BaseEntity<int>
    {
        /// <summary>
        /// ����
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// �ؼ�����
        /// </summary>
        public string control_type { get; set; }

        /// <summary>
        /// �ֶ�����
        /// </summary>
        public string data_type { get; set; }

        /// <summary>
        /// �ֶγ���
        /// </summary>
        public Nullable<int> data_length { get; set; }


        /// <summary>
        /// С����λ��
        /// </summary>
        public Nullable<byte> data_place { get; set; }

        /// <summary>
        /// ѡ���б�
        /// </summary>
        public string item_option { get; set; }

        /// <summary>
        /// Ĭ��ֵ
        /// </summary>
        public string default_value { get; set; }

        /// <summary>
        /// �Ƿ����0�Ǳ���1����
        /// </summary>
        public Nullable<byte> is_required { get; set; }

        /// <summary>
        /// �Ƿ������
        /// </summary>
        public Nullable<byte> is_password { get; set; }

        /// <summary>
        /// �Ƿ�����HTML
        /// </summary>
        public Nullable<byte> is_html { get; set; }

        /// <summary>
        /// �༭������;0:��׼��  1:�����
        /// </summary>
        public Nullable<byte> editor_type { get; set; }

        /// <summary>
        /// ��֤��ʾ��Ϣ
        /// </summary>
        public string valid_tip_msg { get; set; }

        /// <summary>
        /// ��֤ʧ����ʾ��Ϣ
        /// </summary>
        public string valid_error_msg { get; set; }

        /// <summary>
        /// ��֤������ʽ
        /// </summary>
        public string valid_pattern { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Nullable<int> sort_id { get; set; }

        /// <summary>
        /// ϵͳĬ��
        /// </summary>
        public Nullable<byte> is_sys { get; set; }
    }
}
