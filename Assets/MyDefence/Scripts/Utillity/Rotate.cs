using UnityEngine;
namespace MyDefence
{
    //������Ʈ�� Ư���ϴ� ������ ȸ���� �����ϴ� Ŭ����
    public class Rotate : MonoBehaviour
    {
        //ȸ�����, ���ǵ� ����
        public Vector3 rotationSpeed ;

        private void Update()
        {
            transform.localEulerAngles += rotationSpeed;
        }

    }
}