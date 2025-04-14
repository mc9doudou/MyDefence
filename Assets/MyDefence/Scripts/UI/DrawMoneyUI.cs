using UnityEngine;
using TMPro;

namespace MyDefence
{
    //플레이 화면의 Money UI 그리기
    public class DrawMoneyUI : MonoBehaviour
    {
        public TextMeshProUGUI moneyText;
        
        void Update()
        {
            moneyText.text = PlayerStats.Money.ToString();
        }
    }
}
