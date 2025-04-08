using UnityEngine;
namespace MyDefence
{
    public class BuildMenu : MonoBehaviour
    {
        #region Field
        public TowerBluePrint machineGunTower;
        public TowerBluePrint rocketTower;
        #endregion


        //MachineGunButten 클릭시 호출되는 함수
        public void MachineGunButton()
        {
            //빌드매니저의  towerToBuild에 machineGunPrefab을 저장한다
            Debug.Log("towerToBuild에 machineGunPrefab을 저장한다");
            BuildManager.Instance.SetTowerToBuild(machineGunTower.towerPrefab);
        }
    
        public void RocketTowerButton()
        {
            Debug.Log("towerToBuild에 RocketTowerButton을 저장한다");
            BuildManager.Instance.SetTowerToBuild(rocketTower.towerPrefab);
        }
    }
}