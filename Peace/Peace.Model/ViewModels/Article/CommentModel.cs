﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peace.Model.ViewModels.Article
{
    public class CommentModel
    {
        public int id { get; set; }  //主键 

        public int? CreaterId { get; set; }

        public string CreaterName { get; set; }

        public int? UpdaterId { get; set; }

        public string UpdaterName { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 频道ID
        /// </summary>
        public Nullable<int> channel_id { get; set; }

        /// <summary>
        /// 主表ID
        /// </summary>
        public Nullable<int> article_id { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        public string articleTitle { get; set; }
        /// <summary>
        /// 父评论ID
        /// </summary>
        public Nullable<int> parent_id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public Nullable<int> user_id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name { get; set; }

        /// <summary>
        /// 用户IP
        /// </summary>
        public string user_ip { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 是否锁定
        /// </summary>
        public Nullable<byte> is_lock { get; set; }

        /// <summary>
        /// 发表时间
        /// </summary>
        public Nullable<System.DateTime> add_time { get; set; }

        /// <summary>
        /// 是否已答复
        /// </summary>
        public Nullable<byte> is_reply { get; set; }

        /// <summary>
        /// 答复内容
        /// </summary>
        public string reply_content { get; set; }

        /// <summary>
        /// 回复时间
        /// </summary>
        public Nullable<System.DateTime> reply_time { get; set; }
    }
}
