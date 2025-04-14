using UnityEngine;

namespace MyDefence
{
    //ī�޶� �����ϴ� Ŭ����
    public class CameraController : MonoBehaviour
    {
        #region Field
        //ī�޶� �̵��ӵ�
        public float moveSpeed = 10f;

        //ī�޶� ��Ŭ�� ���ǵ�
        public float scrollSpeed = 10f;
        public float scrollMin = 10f;
        public float scrollMax = 10f;

        //ī�޶� ��Ʈ�� ���� ����(true �̸� �� �����δ�,false �����δ�)
        public bool isCannotMove = false;
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�ʱ�ȭ
            isCannotMove = false;
        }

        // Update is called once per frame
        void Update()
        {
            //���� ���� üũ
            if (GameManager.IsGameOver == true)
                return;

            /*//esc key�� �ѹ� ������ ī�޶� �̵��� ���ϰ� �Ѵ� isCannotMove = true (!isCannotMove)
            //esc key�� �ٽ� �ѹ� ������ ī�޶� �̵��� �ϰ� �Ѵ� isCannotMove = false (!isCannotMove)

            if (Input.GetKeyDown(KeyCode.Escape))
            {isCannotMove = !isCannotMove;}
            //isCannotMove�� true�̸� return �Ʒ� �ڵ带 �������� ���� 
            if (isCannotMove) { return; }*/

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
            //���콺 Ȼ�� ��ũ���ϸ� ȭ���� ���� �ܾƿ� �Ѵ�

            float scroll = Input.GetAxis("Mouse ScrollWheel");
            //Debug.Log($"scrollwheel: {scroll}");

            Vector3 upMove = this.transform.position;
            upMove.y -= (scroll * 1000) * Time.deltaTime * scrollSpeed;
            //(pos.y : 10f �̻�, 40f ����)
            upMove.y = Mathf.Clamp(upMove.y, scrollMin, scrollMax);
            this.transform.position = upMove;

            /*if (scroll < 0.1)
            {
                this.transform.Translate(Vector3.up * Time.deltaTime * scrollSpeed, Space.World);
            }
            if (scroll > -0.1)
            {
                this.transform.Translate(Vector3.down * Time.deltaTime * scrollSpeed, Space.World);
            }*/
        }
    }
}

