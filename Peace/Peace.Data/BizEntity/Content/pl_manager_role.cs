using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// �����ɫ��
    /// </summary>
    public partial class pl_manager_role : BaseEntity<int>
    {
        public pl_manager_role()
        {
            this.pl_manager = new List<pl_manager>();
            this.pl_manager_role_value = new List<pl_manager_role_value>();
        }
        /// <summary>
        /// ��ɫ����
        /// </summary>
        public string role_name { get; set; }

        /// <summary>
        /// ��ɫ����
        /// </summary>
        public Nullable<byte> role_type { get; set; }

        /// <summary>
        /// �Ƿ�ϵͳĬ��0��1��
        /// </summary>
        public Nullable<byte> is_sys { get; set; }
        public virtual ICollection<pl_manager> pl_manager { get; set; }
        public virtual ICollection<pl_manager_role_value> pl_manager_role_value { get; set; }
    }
}
