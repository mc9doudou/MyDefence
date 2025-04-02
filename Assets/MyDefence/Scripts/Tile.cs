using UnityEngine;
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

        private Material startMaterial;

        //Ÿ���� Renderer
        private Renderer renderer;
        
        
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //����
            renderer = this.transform.GetComponent<Renderer>();

            //�ʱ�ȭ
            //startcolor = renderer.material.color;
            startMaterial = renderer.material;
        }
        
        private void OnMouseDown()
        {
            //Debug.Log("�� ��ũ��Ʈ�� �پ��ִ� Ÿ������ �ͷ��� ��ġ");
            Instantiate(BuildManager.Instance.GettowerToBuild(), this.transform.position, Quaternion.identity);
        }
        private void OnMouseEnter()
        {

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

