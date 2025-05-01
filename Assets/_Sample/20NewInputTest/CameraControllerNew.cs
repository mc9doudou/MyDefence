using UnityEngine;
using UnityEngine.InputSystem;
namespace Sample
{
    public class CameraControllerNew : MonoBehaviour
    {
        #region Field
        //ī�޶� �̵��ӵ�
        public float moveSpeed = 10f;

        //ī�޶� ��ũ�� ���ǵ�
        public float scrollSpeed = 10f;
        public float scrollMin = 10f;
        public float scrollMax = 40f;

        //New InputAction Ŭ���� ��ü
        private InputActionTest inputActions;

        //��ǲ��
        private Vector2 inputVector;
        #endregion

        #region NewInput - 1�� Script
        /*private void Awake()
        {
            //���� - New InputAction Ŭ���� ��ü �����
            inputActions = new InputActionTest();
        }

        private void OnEnable()
        {
            inputActions.Enable();
        }
        private void OnDisable()
        {
            inputActions.Disable();
        }
        private void Update()
        {
            //Ű �Է°��� ���� ī�޶� �̵�
            inputVector = inputActions.Camera.Move.ReadValue<Vector2>();
            Vector3 dir = new Vector3(inputVector.x, 0, inputVector.y);
            transform.Translate(dir * Time.deltaTime * moveSpeed, Space.World);

            //���콺 ��ġ�� ���� ī�޶� �̵�
            //InputAction���� �� �о����
            //Vector2 mousePos = inputActions.Camera.MousePos.ReadValue<Vector2>();
            //System���� ���콺 ������ �о����
            Vector2 mousePos = Mouse.current.position.ReadValue();
            float mouseX = mousePos.x;
            float mouseY = mousePos.y;
            //���콺 �����Ͱ� ��ũ�� ��ܿ� ��ġ�ϸ�
            if (mouseY >= (Screen.height - 10) && mouseY < Screen.height)
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
            }
            //���콺 �����Ͱ� ��ũ�� �ϴܿ� ��ġ�ϸ�
            if (mouseY <= 10 && mouseY > 0)
            {
                this.transform.Translate(Vector3.back * Time.deltaTime * moveSpeed, Space.World);
            }
            //���콺 �����Ͱ� ��ũ�� ���� ���� ��ġ�ϸ�
            if (mouseX <= 10 && mouseX > 0)
            {
                this.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
            }
            //���콺 �����Ͱ� ��ũ�� ���� ���� ��ġ�ϸ�
            if (mouseX >= Screen.width - 10 && mouseX < Screen.width)
            {
                this.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
            }
        }*/
        #endregion

        #region NewInput - 2�� SendMessage
        /*private void Update()
        {
            //Ű �Է°��� ���� ī�޶� �̵�
            Vector3 dir = new Vector3(inputVector.x, 0, inputVector.y);
            transform.Translate(dir * Time.deltaTime * moveSpeed, Space.World);
        }

        public void OnMove(InputValue value)
        {
            inputVector = value.Get<Vector2>();
        }*/
        #endregion

        #region NewInput - 1�� Event

        private void Update()
        {
            //Ű �Է°��� ���� ī�޶� �̵�
            Vector3 dir = new Vector3(inputVector.x, 0, inputVector.y);
            transform.Translate(dir * Time.deltaTime * moveSpeed, Space.World);
        }

        public void Move(InputAction.CallbackContext context)
        {
            inputVector = context.ReadValue<Vector2>();
        }
        #endregion


        
    }
}
/*
New Input System ���� ���� ��ǲ�� �������� : 3����
1. ��ũ��Ʈ�� �̿��Ͽ� �������� : InputAction�� Class ���Ϸ� ���� ó��
2. Send Message ��� : PlayerInput ������Ʈ �̿��Ͽ� ó�� 
- SendMessage�� ���� ȣ���ϴ� �޼��� ����� ���
: �Լ� �̸� - On + Action�̸� 
: �Ű����� InputValue value 

3. Unity Evens ��� ��� : PlayerInput ������Ʈ�� �̿��Ͽ� ó��
- Unity Events �� �Լ��� ����Ͽ� �޼��带 ȣ���ϴ� ��� 
- �޼��� ����� ��� 
: �Լ� �̸� : x
: �谳���� : InputAction.CallbackContext context
*/