using UnityEngine;
namespace MyDefence
{
    public class FollowUI : MonoBehaviour
    {
        private Camera mainCamera;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            mainCamera = Camera.main;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.rotation = Quaternion.LookRotation(transform.position - mainCamera.transform.position);
        }
    }
}