using UnityEngine;
namespace MyDefence
{
    //Ÿ�� �Ǽ��� �����ϴ� �̱��� ���� Ŭ����
    public class BuildManager : MonoBehaviour
    {
        #region Singleton
        private static  BuildManager instance;

        public static BuildManager Instance
        {
            get
            {
                return instance;
            }
        }
        private void Awake()
        {
            if (instance != null)
            {
                Destroy(gameObject);
                return;
            }
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        #endregion

        #region Field
        //Ÿ�Ͽ� ��ġ�� Ÿ�� ������ ������Ʈ
        private GameObject towerToBuild;
        //Ÿ�� ������
        public GameObject machineGunPrefab;
        #endregion
        private void Start()
        {
            //�ʱ�ȭ
            towerToBuild = machineGunPrefab;
        }

        //Ÿ�Ͽ� ��ġ�� Ÿ�� ������ ������Ʈ ������
        public GameObject GettowerToBuild()
        {
            return towerToBuild;
        }
    }
}