using UnityEngine;
namespace Sample.Generic
{
    public class SingletonTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //SingletonManager �����ϱ�
            SingletonManager.Instance.number = 4567;
            Debug.Log($"{SingletonManager.Instance.number.ToString()}");
        }

        
    }
}