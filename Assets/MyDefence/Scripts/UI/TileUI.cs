using UnityEngine;
using UnityEngine.EventSystems;
namespace MyDefence
{
    public class TileUI : MonoBehaviour
    {
        public GameObject tileUI;
        private GameObject tileOn;

        private BuildManager buildManager;

        //public void 

        private static bool isTileUI = false;
        private void Update()
        {
            if (EventSystem.current.IsPointerOverGameObject() == true)
            {
                ShowTileUI();
            }
        }
        void ShowTileUI()
        {
            isTileUI = true;
            tileUI.SetActive(true);
            //Instantiate(tileUI, tile.transform.position, Quaternion.identity);
            
        }

        

        void Upgrade()
        {

        }

        void Sell()
        {

        }
    }

}