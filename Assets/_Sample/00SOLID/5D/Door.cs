using UnityEngine;
namespace Solid
{
    public class Door : MonoBehaviour
    {
        private bool isActive;
        public bool IsActive => isActive;
        public void Activate()
        {
            isActive = true;
            Debug.Log("���� ������");
        }
        public void Deactivate()
        {
            isActive = false;
            Debug.Log("���� ������");

        }
    }
}