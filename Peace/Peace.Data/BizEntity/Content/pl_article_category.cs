using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// ���ݷ���
    /// </summary>
    public partial class pl_article_category : BaseEntity<int>
    {
        /// Ƶ��ID
        /// </summary>
        public int channel_id { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// ���ñ���
        /// </summary>
        public string call_index { get; set; }

        /// <summary>
        /// �����ID
        /// </summary>
        public Nullable<int> parent_id { get; set; }
        /// <summary>
        /// ���ID�б�(���ŷָ���)
        /// </summary>
        public string class_list { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public Nullable<int> class_layer { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public Nullable<int> sort_id { get; set; }
       
        /// <summary>
        /// URL��ת��ַ
        /// </summary>
        public string link_url { get; set; }

        /// <summary>
        /// ͼƬ��ַ
        /// </summary>
        public string img_url { get; set; }

        /// <summary>
        /// ��ע˵��
        /// </summary>
        public string content { get; set; }

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
    }
}
