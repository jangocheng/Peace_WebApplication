using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// ���ݹ����
    /// </summary>
    public partial class pl_article:BaseEntity<int>
    {
        /// <summary>
        /// Ƶ��ID
        /// </summary>
        public int channel_id { get; set; }
        /// <summary>
        /// ���ID
        /// </summary>
        public int category_id { get; set; }

        /// <summary>
        /// ���ñ���
        /// </summary>
        public string call_index { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// �ⲿ����
        /// </summary>
        public string link_url { get; set; }
        /// <summary>
        /// ͼƬ��ַ
        /// </summary>
        public string img_url { get; set; }
        /// <summary>
        /// SEO����
        /// </summary>
        public string seo_title { get; set; }
        /// <summary>
        /// SEO�ؽ���
        /// </summary>
        public string seo_keywords { get; set; }
        /// <summary>
        /// SEO����
        /// </summary>
        public string seo_description { get; set; }
        /// <summary>
        /// TAG��ǩ���ŷָ�
        /// </summary>
        public string tags { get; set; }

        /// <summary>
        /// ����ժҪ
        /// </summary>
        public string zhaiyao { get; set; }

        /// <summary>
        /// ��ϸ����
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Nullable<int> sort_id { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public Nullable<int> click { get; set; }
        /// <summary>
        /// ״̬0����1δ���2����
        /// </summary>
        public Nullable<byte> status { get; set; }
        /// <summary>
        /// �Ƿ���������
        /// </summary>
        public Nullable<byte> is_msg { get; set; }
        /// <summary>
        /// �Ƿ��ö�
        /// </summary>
        public Nullable<byte> is_top { get; set; }
        /// <summary>
        /// �Ƿ��Ƽ�
        /// </summary>
        public Nullable<byte> is_red { get; set; }
        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public Nullable<byte> is_hot { get; set; }
        /// <summary>
        /// �Ƿ�õ�Ƭ
        /// </summary>
        public Nullable<byte> is_slide { get; set; }
        /// <summary>
        /// �Ƿ����Ա����0����1��
        /// </summary>
        public Nullable<byte> is_sys { get; set; }

        public virtual pl_article_attribute_value pl_article_attribute_value { get; set; }
    }
}
