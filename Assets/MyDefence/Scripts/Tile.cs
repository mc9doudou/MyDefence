using UnityEngine;
using UnityEngine.EventSystems;
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

        private Material startMaterial;

        //타일의 Renderer
        private Renderer renderer;

        //BuildManager 객체
        private BuildManager buildManager;

        //타일에 설치한 타워 오브젝트
        private GameObject tower;
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
            if (buildManager.GetTowerToBuild() == null)
            {
                Debug.Log("설치할 타워이 없습니다");
                return;
            }
            //현재 타일에 타워가 설체되었는지 체크
            if (tower != null)
            {
                Debug.Log("타워를 설체할수 없습니다");
                return;
            }

            //Debug.Log("이 스크립트가 붙어있는 타일위에 터렛을 설치");
            tower = Instantiate(buildManager.GetTowerToBuild(), this.transform.position, Quaternion.identity);

            //초기화 - 저장된 타워 프리팹 초기화 
            buildManager.SetTowerToBuild(null);
        }
        private void OnMouseEnter()
        {
            if (buildManager.GetTowerToBuild() == null)
            {
                //Debug.Log("설치할 타워이 없습니다");
                return;
            }

            //renderer.material.color = hoverColor;
            renderer.material = hoverMaterial;
        }
        private void OnMouseExit()
        {
            //renderer.material.color = startcolor;
            renderer.material = startMaterial;
        }
        
        
    }
}

