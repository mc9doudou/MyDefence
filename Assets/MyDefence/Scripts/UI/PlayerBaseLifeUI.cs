using UnityEngine;
using TMPro;
namespace MyDefence
{
    public class PlayerBaseLifeUI : MonoBehaviour
    {
        #region Field
        //Lives Text UI
        public TextMeshProUGUI healthText;

        public TextMeshProUGUI moneyText;
        #endregion
        // Update is called once per frame
        void Update()
        {
            healthText.text = PlayerStats.Health.ToString();
            moneyText.text = PlayerStats.Money.ToString();
        }
    }
}