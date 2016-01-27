using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Test
{
    public enum NotificationStatus
    {
        /// <summary>
        /// ツイートした
        /// </summary>
        DoTweet,

        /// <summary>
        /// リツイートした
        /// </summary>
        DoRetweet,

        /// <summary>
        /// ふぁぼった
        /// </summary>
        DoFavorite,

        /// <summary>
        /// ふぁぼ解除した
        /// </summary>
        DoUnFavorite,

        /// <summary>
        /// 削除した
        /// </summary>
        DoDelete,

        /// <summary>
        /// リプライが来た
        /// </summary>
        GetReply,

        /// <summary>
        /// リツイートされた
        /// </summary>
        BeRetweet,

        /// <summary>
        /// ふぁぼられた
        /// </summary>
        BeFavorite
    }
}
