using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Playables;
namespace MyDefence
{
    //���� Ÿ���� �����ϴ� Ŭ����
    public class Tile : MonoBehaviour
    {
        #region Field
        //���� ����
        //public Color hoverColor;
        //Ÿ���� ���� ����
        //private Color startcolor;

        //���콺�� �÷������� ���ϴ� ���͸���
        public Material hoverMaterial;

        public Material nullMaterial;

        private Material startMaterial;

        //Ÿ���� Renderer
        private Renderer renderer;

        //BuildManager ��ü
        private BuildManager buildManager;

        //Ÿ�Ͽ� ��ġ�� Ÿ�� ������Ʈ
        private GameObject tower;

        private TowerBluePrint bluePrint;

        //��ġ�� Ÿ�� ��������
        public GameObject buildEffectPrefab;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //����
            renderer = this.transform.GetComponent<Renderer>();
            buildManager = BuildManager.Instance;
            //�ʱ�ȭ
            //startcolor = renderer.material.color;
            startMaterial = renderer.material;
        }
        
        private void OnMouseDown()
        {
            //Ÿ������ UI�� �ִ��� üũ 
            if(EventSystem.current.IsPointerOverGameObject() == true)
            {
                return;
            }
            //����� ������ üũ
            if (buildManager.CannotBuild)
            {
                Debug.Log("��ġ�� Ÿ���� �����ϴ�");
                return;
            }
            //���� Ÿ�Ͽ� Ÿ���� ��ü�Ǿ����� üũ
            if (tower != null)
            {
                Debug.Log("Ÿ���� ��ġ�Ҽ� �����ϴ�");
                return;
            }
            //Ÿ���� �Ǽ��Ѵ�
            BuildTower();
            
        }

        void BuildTower()
        {
            //�Ǽ� ��� üũ
            
            if (buildManager.NotEnoughMoney)
                return;
            
            //�Ǽ��� Ÿ���� ������ ����
            bluePrint = buildManager.GetTowerToBuild();

            //�� ���
            PlayerStats.UseMoney(bluePrint.cost);
            //Debug.Log("�� ��ũ��Ʈ�� �پ��ִ� Ÿ������ �ͷ��� ��ġ");
            tower = Instantiate(bluePrint.towerPrefab, this.transform.position, Quaternion.identity);

            //�Ǽ� ����Ʈ ó��
            GameObject effectGo = Instantiate(buildEffectPrefab, this.transform.position,Quaternion.identity);
            Destroy(effectGo,2f);
            
            //�ʱ�ȭ - ����� Ÿ�� ������ �ʱ�ȭ 
            buildManager.SetTowerToBuild(null);

            Debug.Log($"�Ǽ��ϰ� ������:{PlayerStats.Money}");
        }
        private void OnMouseEnter()
        {
            
            if (buildManager.CannotBuild)
            {
                //Debug.Log("��ġ�� Ÿ���� �����ϴ�");
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

