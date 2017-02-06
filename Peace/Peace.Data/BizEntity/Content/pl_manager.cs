using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// ����Ա��Ϣ��
    /// </summary>
    public partial class pl_manager : BaseEntity<int>
    {
        /// <summary>
        ///��ɫID
        /// </summary>
        public Nullable<int> role_id { get; set; }

        /// <summary>
        /// ����Ա����1����2ϵ�ܣ�Ĭ�ϣ�2��
        /// </summary>
        public Nullable<int> role_type { get; set; }

        /// <summary>
        /// �û���
        /// </summary>
        public string user_name { get; set; }

        /// <summary>
        ///��¼���� 
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 6λ����ַ���,�����õ�
        /// </summary>
        public string salt { get; set; }

        /// <summary>
        /// �û��ǳ�
        /// </summary>
        public string real_name { get; set; }

        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string telephone { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public Nullable<int> is_lock { get; set; }
        public Nullable<System.DateTime> add_time { get; set; }
        public virtual pl_manager_role pl_manager_role { get; set; }
    }
}
