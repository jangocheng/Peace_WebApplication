using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// ������־��
    /// </summary>
    public partial class pl_manager_log : BaseEntity<int>
    {
        /// <summary>
        ///��������
        /// </summary>
        public string action_type { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// �û�IP
        /// </summary>
        public string user_ip { get; set; }
    }
}
