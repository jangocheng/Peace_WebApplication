using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// �����ɫȨ�ޱ����������Դ˵���������ɾ�Ĳ飩
    /// </summary>
    public partial class pl_manager_role_value
    {
        public int id { get; set; }
        /// <summary>
        /// ��ɫID
        /// </summary>
        public Nullable<int> role_id { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string nav_name { get; set; }

        /// <summary>
        /// Ȩ������
        /// </summary>
        public string action_type { get; set; }
        public virtual pl_manager_role pl_manager_role { get; set; }
    }
}
