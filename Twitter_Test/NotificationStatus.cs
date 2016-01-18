using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Test
{
    enum NotificationStatus
    {
        // ツイートした
        DoTweet,

        // リツイートした
        DoRetweet,

        // ふぁぼった
        DoFavorite,

        // ふぁぼ解除した
        DoUnFavorited,

        // 削除した
        DoDelete,

        // リプライが来た
        GetReply,

        // リツイートされた
        BeRetweet,

        // ふぁぼられた
        BeFavorite
    }
}
