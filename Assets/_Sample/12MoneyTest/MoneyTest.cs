using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace Sample
{
    public class MoneyTest : MonoBehaviour
    {
        #region Field
        //������ 
        private int gold;


        [SerializeField]
        private int startGold;

        //Gold UI
        public TextMeshProUGUI goldText;

        //Button UI
        public Button button1000;
        public Button button9000;
        #endregion
        private void Start()
        {
            //�ʱ�ȭ - ���� ó�� �����Ҷ� startGold�� �ʱ�ȭ
            //������ ����
            gold = startGold;
            Debug.Log($"������ {startGold}���� �����߽��ϴ�");

            //ex ��ư �̹��� ���� �ٲٱ�
            button1000.image.color = Color.blue;

        }
        private void Update()
        {//�������� �����Ͽ� ���Ű� �Ұ����� ��� �̹��� red
            if (HasGold(1000))
            {
                button1000.interactable = true;
                //button1000.image.color = Color.white;
            }
            else
            {
                button1000.interactable = false;
                //button1000.image.color = Color.red;
            }
            if (HasGold(9000))
            {
                button1000.interactable = true;
                //button9000.image.color = Color.white;
            }
            else
            {
                button1000.interactable = false;
                //button9000.image.color = Color.red;
            }
            //������(gold)�� UI(����ؽ�Ʈ) ���� 
            goldText.text = gold.ToString() + " Gold";
        }
        //Gold�� �����ϴ� �Լ�
        //���� ����: ���, ����Ʈ Ŭ����, �ɽ� ����, �̺�Ʈ ���� ...
        public void AddGold(int amount)
        {
            gold += amount;
        }

        //���� ����: ������ ����, �ⱸ ���....
        //���� �����ϸ� ���� ������� �ʰ� return false;
        //���� ����ϸ� ���� ����ϰ� return true;

        public bool UseGold(int amount)
        {
            //������ üũ
            if (gold < amount)
            {
                Debug.Log("������ �����մϴ�");
                return false;
            }
            gold -= amount;
            return true;
        }

        //������ üũ:amount ��ŭ �������� ������ �ִ��� ����
        //���� ������� �ʰ�

        public bool HasGold(int amount)
        {
            if (gold < amount)
            {
                
                return false;
            }
            
            return true;
        }

        //��ư 3�� Ŭ���� ȣ��Ǵ� �Լ� 3�� ����� �� ��ư�� �����ϼ���
        //��ư Ŭ���� Gold ����ϰ� ����ϼ���
        public void SaveButton()
        {
            AddGold(1000);
            Debug.Log("1000 Gold Save");
        }

        public void Item1000()
        {
            if (UseGold(1000) == true)
            {
                Debug.Log("1000 Item ����");
            }
        }

        public void Item9000()
        {
            if(UseGold(9000) == true)
            {
                Debug.Log("9000 Item ����");
            }
            
        }
    
    }
}
/*
MoneyTest
1. �����ϸ� �������� 1000G ����
2. ȭ���ܿ� ������ UI ǥ��(1000 Gold)
3. ��ư 3�� 
1) ���� ��ư : 1000G ����, ��ư Ŭ���� + 1000, "1000 Gold Save" ���

2) ���� ��ư : 1000G ������ ����, ��ư Ŭ���� -1000, "1000 Item Purchase" ���
3) ���� ��ư : 9000G ������ ����, ��ư Ŭ���� -9000, "9000 Item Purchase" ���

���� ��ư : ������ ���Ű� �����ϸ� ��ư �̹����� white, 
           ������ �����Ͽ� ���Ű� �Ұ����ϸ� �̹��� red,
           ���Ű� �Ұ����ϸ� ���Ź�ư Ŭ���ص� ���� �Ұ����ؾ� �Ѵ�
*/