using UnityEngine;
namespace MyDefence
{
    //타워 건설을 관리하는 싱글톤 패턴 클래스
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
        //타일에 설치할 타워 정보를 저장하는 변수
        private TowerBluePrint towerToBuild;
        //타일에 설치할 타워 건설 비용
        private int cost;

        #endregion
        #region Property
        //타워 건설비용을 체크: 부족하면 true
        public bool NotEnoughMoney
        {
            get { return PlayerStats.Money < towerToBuild.cost; }
        }

        //건설할 타워가 없을때, 건설할 타워를 선택하지 않았을때
        public bool CannotBuild
        {
            get { return towerToBuild == null; }
        }

        #endregion

        private void Start()
        {
            //초기화
            
        }

        //타일에 설치할 타워 프리펩 오브젝트 저장하기
        
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