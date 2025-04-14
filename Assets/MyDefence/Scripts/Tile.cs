using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Playables;
namespace MyDefence
{
    //맵의 타일을 관리하는 클래스
    public class Tile : MonoBehaviour
    {
        #region Field
        //색상 선택
        //public Color hoverColor;
        //타일의 원래 색깔
        //private Color startcolor;

        //마우스를 올려놓으면 변하는 메터리얼
        public Material hoverMaterial;

        public Material nullMaterial;

        private Material startMaterial;

        //타일의 Renderer
        private Renderer renderer;

        //BuildManager 객체
        private BuildManager buildManager;

        //타일에 설치한 타워 오브젝트
        private GameObject tower;

        private TowerBluePrint bluePrint;

        //설치한 타워 가져오기
        public GameObject buildEffectPrefab;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //참조
            renderer = this.transform.GetComponent<Renderer>();
            buildManager = BuildManager.Instance;
            //초기화
            //startcolor = renderer.material.color;
            startMaterial = renderer.material;
        }
        
        private void OnMouseDown()
        {
            //타일위에 UI가 있는지 체크 
            if(EventSystem.current.IsPointerOverGameObject() == true)
            {
                return;
            }
            //저장된 프리팹 체크
            if (buildManager.CannotBuild)
            {
                Debug.Log("설치할 타워이 없습니다");
                return;
            }
            //현재 타일에 타워가 설체되었는지 체크
            if (tower != null)
            {
                Debug.Log("타워를 설치할수 없습니다");
                return;
            }
            //타워를 건설한다
            BuildTower();
            
        }

        void BuildTower()
        {
            //건설 비용 체크
            
            if (buildManager.NotEnoughMoney)
                return;
            
            //건설할 타워의 정보를 저장
            bluePrint = buildManager.GetTowerToBuild();

            //돈 계산
            PlayerStats.UseMoney(bluePrint.cost);
            //Debug.Log("이 스크립트가 붙어있는 타일위에 터렛을 설치");
            tower = Instantiate(bluePrint.towerPrefab, this.transform.position, Quaternion.identity);

            //건설 이팩트 처리
            GameObject effectGo = Instantiate(buildEffectPrefab, this.transform.position,Quaternion.identity);
            Destroy(effectGo,2f);
            
            //초기화 - 저장된 타워 프리팹 초기화 
            buildManager.SetTowerToBuild(null);

            Debug.Log($"건설하고 님은돈:{PlayerStats.Money}");
        }
        private void OnMouseEnter()
        {
            
            if (buildManager.CannotBuild)
            {
                //Debug.Log("설치할 타워이 없습니다");
                return;
            }
            if (buildManager.NotEnoughMoney)
            {
                renderer.material = nullMaterial;
            }
            else
            {
                //renderer.material.color = hoverColor;
                renderer.material = hoverMaterial;
            }
        }
        private void OnMouseExit()
        {
            //renderer.material.color = startcolor;
            renderer.material = startMaterial;
        }
    }
}

