using UnityEngine;
namespace MyDefence
{
    public class BuildMenu : MonoBehaviour
    {
        //MachineGunButten Ŭ���� ȣ��Ǵ� �Լ�
        public void MachineGunButton()
        {
            //����Ŵ�����  towerToBuild�� machineGunPrefab�� �����Ѵ�
            Debug.Log("towerToBuild�� machineGunPrefab�� �����Ѵ�");
            BuildManager.Instance.SetTowerToBuild(BuildManager.Instance.machineGunPrefab);
        }
    
        public void RocketTowerButton()
        {
            Debug.Log("towerToBuild�� RocketTowerButton�� �����Ѵ�");
            BuildManager.Instance.SetTowerToBuild(BuildManager.Instance.rocketTowerPrefab);
        }
    }
}