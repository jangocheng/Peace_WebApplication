using System;
using System.Collections.Generic;

namespace Peace.Data
{
    /// <summary>
    /// ϵͳƵ����
    /// </summary>
    public partial class pl_channel : BaseEntity<int>
    {
        /// <summary>
        ///    //վ��Id
        /// </summary>
        public Nullable<int> site_id { get; set; }
        /// <summary>
        ///  //Ƶ������
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Ƶ������
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// �Ƿ�����Ṧ�ܣ���ҳ�õ�Ƭչʾ���Ƿ񽫸�ƪ�ĵ���Ϊ�õ�Ƭչʾ��
        /// </summary>
        public Nullable<byte> is_albums { get; set; }
        /// <summary>
        /// �Ƿ�����������
        /// </summary>
        public Nullable<byte> is_attach { get; set; }
        /// <summary>
        /// �Ƿ������
        /// </summary>
        public Nullable<byte> is_spec { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Nullable<int> sort_id { get; set; }
        public virtual pl_channel_site pl_channel_site { get; set; }
    }
}
