using UnityEngine;
using UnityEngine.UI;
namespace MyDefence
{
    public class LevelSelect :MonoBehaviour
    {
        #region
        public SceneFader fader;
        [SerializeField]
        private string loadToScene = "MainMenu";

        //���� ���� ��ư
        public Transform contents;      //�������� ��ư���� �θ� ������Ʈ4
        private Button[] levelButtons;

        //�ڵ� ��ũ�� ���
        public RectTransform scrollRect;
        public RectTransform contentsRect;

        public Scrollbar scrollbar;
        #endregion

        private void Start()
        {
            //���ӽ���� ó������ ����� ������(NowLevel) ��������
            int nowLevel = PlayerPrefs.GetInt("NowLevel", 1);
            //Debug.Log($"NowLevel: {nowLevel}");

            //���� ��ưs �ʱ�ȭ
            //���� ��ư �迭 ����
            levelButtons = new Button[contents.childCount];

            //�� ���� ��ư ����
            for (int i = 0; i < levelButtons.Length; i++)
            {
                levelButtons[i] = contents.GetChild(i).GetComponent<Button>();
                if (i>=nowLevel)
                {
                    levelButtons[i].interactable = false;
                }
            }

            //���� �ÿ����� ������ �ڵ� ��ũ��
            float scrollHeight = scrollRect.rect.height;
            //Debug.Log($"scrollHeight: {scrollHeight}");
            float contentsHeight = 190+(int)((levelButtons.Length-1)/5)*(190+5) ;
            //Debug.Log($"contentHeight: {contentsHeight}");
            //��ü ��ũ�� ��
            float dHeight = contentsHeight - scrollHeight;
            if (dHeight > 0)
            {
                //���� �÷����� ������ ���� ��ũ�� ���� 
                float nowLevelHeight = (int)((nowLevel - 1) / 5) * (190 + 5);
                if (nowLevelHeight<dHeight)
                {
                    scrollbar.value = 1-nowLevelHeight / dHeight;
                }
                else
                {
                    scrollbar.value = 0;
                }
            }
        }

        //���� ��ư Ŭ���� �Ű������� ���� ���̸����� �̵��Ѵ�
        public void LevelButtonSelect(string sceneName)
        {
            //Debug.Log($"{sceneName}������ �̵�");
            fader.FadeTo(sceneName);
        }
        //�޴�����
        public void ExitButton()
        {
            fader.FadeTo(loadToScene);
        }
    }
}
/*
���� ������ ó�� : save/ load
: ���� ������ - ������ ������ �÷��� �ϸ鼭 ������ ������ 
: ���� ����ÿ��� �����Ǿ�� �ϴ� ������

-���� ���̺� - ���� ����
1. ������ �����ϸ� ����� ���� �����Ͱ� �ִ��� ������ ���� üũ
������ ������ - ���� �����͵��� ���� �ʱ� �����ͷ� �ʱ�ȭ �� �����Ͽ� ������ �����
������ ������ - ������ �о ����� �����ͷ� ���� �����͵��� ���� �ʱ�ȭ

2. ���� ��ġ/ ����

3. ����� ����� �����Ϳ� ���� ������ �������� ��



//PlayerPrefs save/load
playerPrefs.SetInt(string KeyName,int Value);       //KeyName �̸����� Value ������
PlayerPrafs.GetInt(stringKeyName)                   //KeyName �̸����� ����� �� ��������

playerPrefs.SetFloat(string KeyName,float Value);   //KeyName �̸����� Value ������
PlayerPrafs.GetFloat(stringKeyName)                 //KeyName �̸����� ����� �� ��������
    
playerPrefs.SetString(string KeyName,string Value); //KeyName �̸����� Value ������
PlayerPrafs.GetString(stringKeyName)                //KeyName �̸����� ����� �� ��������


*/