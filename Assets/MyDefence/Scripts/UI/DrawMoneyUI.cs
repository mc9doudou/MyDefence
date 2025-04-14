using UnityEngine;
using TMPro;

namespace MyDefence
{
    //�÷��� ȭ���� Money UI �׸���
    public class DrawMoneyUI : MonoBehaviour
    {
        public TextMeshProUGUI moneyText;
        
        void Update()
        {
            moneyText.text = PlayerStats.Money.ToString();
        }
    }
}
