using UnityEngine;
namespace Solid
{
    //����ġ ��� ����
    public interface ISwitchable 
    {
        public bool IsActive { get; }
        public void Activate();
        public void Deactivate();
    }
}