using UnityEngine;
namespace Solid
{
    public class Robot : MonoBehaviour, ISwitchable
    {
        private bool isActive;
        public bool IsActive => isActive;
        public void Activate()
        {
            isActive = true;
            Debug.Log("�κ��� �����δ�");
        }
        public void Deactivate()
        {
            isActive = false;
            Debug.Log("�κ��� �����");

        }
    }
}