using UnityEngine;
using TMPro;

namespace MyDefence
{
    public class InputTest : MonoBehaviour
    {
        //UI Text
        public TextMeshProUGUI xText;
        public TextMeshProUGUI yText;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //��ũ�� ũ��
            Debug.Log($"Screen.width: {Screen.width}");
            Debug.Log($"Screen.height: {Screen.height}");
        }

        // Update is called once per frame
        void Update()
        {
            //GetKey(Ű��)
            /*if (Input.GetKey("w"))
            {
                Debug.Log("w");
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("wŰ�� �������ϴ�");
            }
            if (Input.GetKeyUp("w"))
            {
                Debug.Log("wŰ�� �����ٰ� �������ϴ�");
            }*/

            //GetButton(��ư�̸�) - InputManager
            /*if (Input.GetButton("Jump"))
            {
                Debug.Log("���� ��ư�� ������ �ֽ��ϴ�");
            }
            if (Input.GetButtonDown("Jump"))
            {
                Debug.Log("���� ��ư�� �������ϴ�");
            }
            if (Input.GetButtonUp("Jump"))
            {
                Debug.Log("���� ��ư�� �����ٰ� �������ϴ�");
            }*/

            //GetAxis(Axis�̸�) - InputManager
            //float hValue = Input.GetAxis("Horizontal");
            //Debug.Log($"Horizontal �� : {hValue}");
            //a, left : -1 ~ 0
            //d, right : 0 ~ 1 
            //float hValue = Input.GetAxisRaw("Horizontal");
            //Debug.Log($"Horizontal �� : {hValue}");
            //a, left : -1, 0
            //d, right : 0, 1 

            //float vValue = Input.GetAxis("Vertical");
            //Debug.Log($"Vertical �� :{vValue}");
            //s, down : -1 ~ 0
            //w, up : 0 ~ 1

            //���콺 �������� ��ũ�� ��ġ�� ������
            float mouseX = Input.mousePosition.x;
            float mouseY = Input.mousePosition.y;

            //xText.text = "MouseX:" + ((int)mouseX).ToString();
            //yText.text = "MouseY:" + ((int)mouseY).ToString();
            xText.text = "MouseX:" + ((int)mouseX).ToString() + "," + ((int)mouseY).ToString(); ;
            xText.rectTransform.position = new Vector2(mouseX,mouseY);

        }
    }
}
