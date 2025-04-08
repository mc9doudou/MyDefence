using UnityEngine;
namespace MyDefence
{
    public class BuildMenu : MonoBehaviour
    {
        #region Field
        public TowerBluePrint machineGunTower;
        public TowerBluePrint rocketTower;
        #endregion


        //MachineGunButten Ŭ���� ȣ��Ǵ� �Լ�
        public void MachineGunButton()
        {
            //����Ŵ�����  towerToBuild�� machineGunPrefab�� �����Ѵ�
            Debug.Log("towerToBuild�� machineGunPrefab�� �����Ѵ�");
            BuildManager.Instance.SetTowerToBuild(machineGunTower.towerPrefab);
        }
    
        public void RocketTowerButton()
        {
            Debug.Log("towerToBuild�� RocketTowerButton�� �����Ѵ�");
            BuildManager.Instance.SetTowerToBuild(rocketTower.towerPrefab);
        }
    }
}