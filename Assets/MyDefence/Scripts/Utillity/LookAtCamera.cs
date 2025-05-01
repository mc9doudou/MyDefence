using UnityEngine;
namespace MyDefence
{
    public class LookAtCamera : MonoBehaviour
    {
        //ī�޶� ���� �ٶ󺻴�
        #region Field
        private Camera m_MainCamera; 
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //���� 
            m_MainCamera = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {
            //transform.LookAt(m_MainCamera.transform);
            //���� ���� ������ x�� ������ ��ġ�� ������ Ÿ���� ����� �ٶ󺻴�
            Vector3 target = new Vector3(this.transform.position.x, m_MainCamera.transform.position.y, m_MainCamera.transform.position.z);
            transform.LookAt(target);
        
        }
    }
}