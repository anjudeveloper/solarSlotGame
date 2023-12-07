using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Mkey
{
    public class DailyRewardLine : MonoBehaviour
    {
        [SerializeField]
        private Image rewardReceivedImage;
        [SerializeField]
        private Image currentRewardImage;
        [SerializeField]
        private Text dayText;

        #region temp vars

        #endregion temp vars

        public void SetData(GameReward reward, int day, int rewardDay)
        {
            if (rewardReceivedImage)
            {
                rewardReceivedImage.gameObject.SetActive((day < rewardDay));
            }
            if (currentRewardImage)
            {
                currentRewardImage.gameObject.SetActive(day == rewardDay);
            }
            if (dayText && day == rewardDay)
            {
                dayText.text = "GET!!!";
            }
        }
    }
}
