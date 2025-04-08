using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
namespace MyDefence
{
    //�÷��̾��� �Ӽ����� �����ϴ� Ŭ����
    public class PlayerStats : MonoBehaviour
    { 
        #region Field
        //������
        private static int money;

        [SerializeField]
        private int startmoney = 400;

        public TextMeshProUGUI moneyText;
        #endregion

        #region Property
        //������ �б� ���� �Ӽ�
        public static int Money
        {
            get { return money; }
        }
        #endregion
        

        //������ �ʱⰪ 400
        //����, ����, ������ Ȯ�� �Լ� ����� 
        public Button machineGunTower;
        public Button rocketTower;

        private void Start()
        {
            //������ ���� 400
            money = startmoney;
        }
        private  void Updata()
        {
            if (HasMoney(1000))
            {
                machineGunTower.interactable = true;
            }
            else
            {
                machineGunTower.interactable = false;
            }
            if (HasMoney(9000))
            {
                rocketTower.interactable = true;
            }
            else
            {
                rocketTower.interactable = false;
            }
            //������(gold)�� UI(����ؽ�Ʈ) ���� 
            moneyText.text = money.ToString() + " Gold";
        }
        public static void AddMoney(int amount)
        {
            money += amount;
        }

        public static bool UseMoney(int amount)
        {
            
            if (money < amount)
            {
                Debug.Log("���� �����մϴ�");
                return false;
            }
            money -= amount;
            return true;
        }
        public static bool HasMoney(int amount)
        {
            return money >= amount;
            /*//������ üũ
            if (money < amount)
            {
                return false;
            }
            return true;*/
        }

        public static void MachineGunTower()
        {
            if (UseMoney(100) == true)
            {
                Debug.Log($"�Ǽ��ϰ� ������ :{money - 100}");
            }
        }
        public static void RocketTower()
        {
            if (UseMoney(250) == true)
            {
                Debug.Log($"�Ǽ��ϰ� ������ :{money - 250}");
            }
        }

    }
}