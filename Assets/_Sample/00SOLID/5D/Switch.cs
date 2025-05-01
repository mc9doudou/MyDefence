using UnityEngine;
namespace Solid
{
    public class Switch : MonoBehaviour 
    {
        //public Door door;
        //public Robot robot;
        public Transform switchTransform;
        private ISwitchable client;      //Door,Robot

        public bool IsActive => throw new System.NotImplementedException();

        void Start()
        {
            client = switchTransform.GetComponent<ISwitchable>();
            Debug.Log(client);
        }
        public void Toggle() {
            if (client.IsActive)
            {
                client.Deactivate();
            }
            else
            {
                client.Activate();
            }
        }

        
    }
}