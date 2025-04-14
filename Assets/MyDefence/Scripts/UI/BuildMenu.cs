using UnityEngine;
namespace MyDefence
{
    public class BuildMenu : MonoBehaviour
    {
        #region Field
        //Ÿ��(�Ǽ�) ������ ������ �ִ� ��ü
        public TowerBluePrint machineGunTower;
        public TowerBluePrint rocketTower;
        public TowerBluePrint laserTower;
        #endregion


        //MachineGunButten Ŭ���� ȣ��Ǵ� �Լ�
        public void MachineGunButton()
        {
            //����Ŵ�����  towerToBuild�� machineGunPrefab�� �����Ѵ�
            //Debug.Log("towerToBuild�� machineGunPrefab�� �����Ѵ�");
            BuildManager.Instance.SetTowerToBuild(machineGunTower);
        }
    
        public void RocketTowerButton()
        {
            //Debug.Log("towerToBuild�� RocketTowerButton�� �����Ѵ�");
            BuildManager.Instance.SetTowerToBuild(rocketTower);
        }

        public void LaserTowerButton()
        {
            BuildManager.Instance.SetTowerToBuild(laserTower);
        }
    }
}