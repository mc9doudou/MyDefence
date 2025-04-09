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
        //Ÿ�Ͽ� ��ġ�� Ÿ�� ������ �����ϴ� ����
        private TowerBluePrint towerToBuild;
        //Ÿ�Ͽ� ��ġ�� Ÿ�� �Ǽ� ���
        private int cost;

        #endregion
        private void Start()
        {
            //�ʱ�ȭ
            
        }

        //Ÿ�Ͽ� ��ġ�� Ÿ�� ������ ������Ʈ �����ϱ�
        
        public TowerBluePrint GetTowerToBuild()
        {
            return towerToBuild;
        }
        public void SetTowerToBuild(TowerBluePrint tower)
        {
            towerToBuild = tower;
            
        }
        
        
    
    }
}