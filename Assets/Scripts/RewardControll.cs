using UnityEngine.UI;
using UnityEngine;

public class RewardControll : MonoBehaviour
{
    ushort countReward = 0;
    public Text countText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        countReward++;
        if (TubeSize.isHardMode == true)
        {
            countReward++;
        }
       
        countText.text = $"Очки: {countReward}";
    }
}
