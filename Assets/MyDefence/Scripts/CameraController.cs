using UnityEngine;

namespace MyDefence
{
    //카메라를 제어하는 클래스
    public class CameraController : MonoBehaviour
    {
        #region Field
        //카메라 이동속도
        public float moveSpeed = 10f;

        //카메라 스클롤 스피드
        public float scrollSpeed = 10f;
        public float scrollMin = 10f;
        public float scrollMax = 10f;

        //카메라 컨트롤 제어 유무(true 이면 못 움직인다,false 움직인다)
        public bool isCannotMove = false;
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //초기화
            isCannotMove = false;
        }

        // Update is called once per frame
        void Update()
        {
            //게임 오버 체크
            if (GameManager.IsGameOver == true)
                return;

            /*//esc key를 한번 누르면 카메라 이동을 못하게 한다 isCannotMove = true (!isCannotMove)
            //esc key를 다시 한번 누르면 카메라 이동을 하게 한다 isCannotMove = false (!isCannotMove)

            if (Input.GetKeyDown(KeyCode.Escape))
            {isCannotMove = !isCannotMove;}
            //isCannotMove가 true이면 return 아래 코드를 실행하지 말라 
            if (isCannotMove) { return; }*/

            //A,S,D,W 키 (키보드의 상하좌우 화살표)값을 받아 맵을 스크롤 시킨다 -> 카메라 이동 시키면
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

            //마우스 포인터가 스크린 상단에 위치하면 
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
            //마우스 횔을 스크롤하면 화면이 줌인 줌아웃 한다

            float scroll = Input.GetAxis("Mouse ScrollWheel");
            //Debug.Log($"scrollwheel: {scroll}");

            Vector3 upMove = this.transform.position;
            upMove.y -= (scroll * 1000) * Time.deltaTime * scrollSpeed;
            //(pos.y : 10f 이상, 40f 이하)
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

