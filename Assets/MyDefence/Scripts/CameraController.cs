using UnityEngine;

namespace MyDefence
{
    //ī�޶� �����ϴ� Ŭ����
    public class CameraController : MonoBehaviour
    {
        #region Field
        //ī�޶� �̵��ӵ�
        public float moveSpeed = 10f;

        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //A,S,D,W Ű (Ű������ �����¿� ȭ��ǥ)���� �޾� ���� ��ũ�� ��Ų�� -> ī�޶� �̵� ��Ű��
            if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3.back * Time.deltaTime * moveSpeed, Space.World);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
            }

            //���콺 �����Ͱ� ��ũ�� ��ܿ� ��ġ�ϸ� 
            float mouseX = Input.mousePosition.x;
            float mouseY = Input.mousePosition.y;
            if (mouseY > (Screen.height - 10) && mouseY <Screen.height)
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
            }
            if (mouseY < 10 && mouseY > 0)
            {
                this.transform.Translate(Vector3.back * Time.deltaTime * moveSpeed, Space.World);
            }
            if (mouseX > 0 && mouseX < 10)
            {
                this.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
            }
            if (mouseX > (Screen.width-10)&& mouseX < Screen.width)
            {
                this.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
            }
        }
    }
}

