using UnityEngine;
namespace Sample
{
    public class SerializeTest : MonoBehaviour
    {
        #region Field
        public int number = 10;

        /*[SerializeField]
        //private string name = "abcd";

        private string car = "ave";*/

        [SerializeField]
        private TestStruct testStruct;

        public Transform target;

        public GameObject prefabTest;
        #endregion
    }
}