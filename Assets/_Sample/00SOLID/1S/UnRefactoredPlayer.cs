using UnityEngine;
namespace Solid
{
    //�÷��̾ �����ϴ� Ŭ���� : ��ǲ, �̵�, ����, ����Ʈ 

    public class UnRefactoriedPlayer : MonoBehaviour
    {
        //�̵�
        private Vector3 inputVector;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            HandleInput();
            Move(inputVector);
            PlayRandomAudioClip();
            PlayEffect();
        }

        //�÷��̾� ��ǲ ó��
        private void HandleInput()
        {
            //��ǲ ��� ����

        }

        //�÷��̾� �̵� 
        private void Move(Vector3 inputVector)
        {
            //�̵� ��� ����
        }

        //�÷��̾� ����
        private void PlayRandomAudioClip()
        {
            //���� ��� ����

        }

        //�÷��̾� ����Ʈ 
        private void PlayEffect()
        {
            //����Ʈ �÷���
        }
    }
}