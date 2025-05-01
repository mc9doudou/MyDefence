using UnityEngine;
using UnityEngine.UI;
namespace MyDefence
{
    public class ImageTest : MonoBehaviour
    {
        #region Field
        //��ų ��ư
        public Button skillButton;
        public Image skillButtonImage;
        public GameObject panel;

        [SerializeField]
        private float coolTime = 3f;
        private float countdown = 0f;

        //�� Ÿ�� üũ
        private bool isCharge = false;
        #endregion
        private void Start()
        {
            //�ʱ�ȭ
            countdown = 0f;
            isCharge = true;
            panel.SetActive(false);
        }

        private void Update()
        {
            if (isCharge)
              return;

            countdown += Time.deltaTime;
            if (countdown >= coolTime)
            {
                //Ÿ�̸� ���
                skillButton.interactable = true;

                //panel �̹��� ��Ȱ��ȭ
                panel.SetActive(false);

                //Ÿ�̸� �ʱ�ȭ
                countdown = 0f;
                isCharge = true;
            }

            //countdown : 0 -> 3, fillamunt 0 -> 1(100%, �Ҽ���, �м�)
            //����� : (���簪��: countdown) / (�Ѱ���: cooltime) 
            skillButtonImage.fillAmount =countdown / coolTime;

        }
        //��ų ��ư Ŭ���� ȣ��Ǵ� �Լ�
        public void SkillUse()
        {
            //skillButtonImage.isActiveAndEnabled(false);
            skillButton.interactable = false;

            //panel �̹��� Ȱ��ȭ
            panel.SetActive(true);

            countdown = 0f;
            isCharge = false;
            //Debug.Log("Skill Use");
        }
    }
}