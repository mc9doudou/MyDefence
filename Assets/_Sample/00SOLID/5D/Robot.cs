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
            Debug.Log("∑Œ∫ø¿Ã øÚ¡˜¿Œ¥Ÿ");
        }
        public void Deactivate()
        {
            isActive = false;
            Debug.Log("∑Œ∫ø¿Ã ∏ÿ√·¥Ÿ");

        }
    }
}