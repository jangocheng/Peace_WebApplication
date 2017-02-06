using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// Ƶ������
    /// </summary>
    public partial class pl_channel_site : BaseEntity<int>
    {
        public pl_channel_site()
        {
            this.pl_channel = new List<pl_channel>();
        }

        /// <summary>
        /// ����
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// ����Ŀ¼��
        /// </summary>
        public string build_path { get; set; }

        /// <summary>
        /// ģ��Ŀ¼��
        /// </summary>
        public string templet_path { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string domain { get; set; }
        /// <summary>
        /// ��վ����
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// ��վLOGO
        /// </summary>
        public string logo { get; set; }

        /// <summary>
        /// ��˾����
        /// </summary>
        public string company { get; set; }

        /// <summary>
        /// ͨѶ��ַ
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string tel { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public string fax { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string crod { get; set; }

        /// <summary>
        /// ��Ȩ��Ϣ
        /// </summary>
        public string copyright { get; set; }
        /// <summary>
        /// SEO����
        /// </summary>
        public string seo_title { get; set; }

        /// <summary>
        /// SEO�ؽ���
        /// </summary>
        public string seo_keyword { get; set; }

        /// <summary>
        /// SEO����
        /// </summary>
        public string seo_description { get; set; }

        /// <summary>
        /// �Ƿ��ƶ�վ
        /// </summary>
        public Nullable<byte> is_mobile { get; set; }

        /// <summary>
        /// �Ƿ�Ĭ��
        /// </summary>
        public Nullable<byte> is_default { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Nullable<int> sort_id { get; set; }
        public virtual ICollection<pl_channel> pl_channel { get; set; }
    }
}
