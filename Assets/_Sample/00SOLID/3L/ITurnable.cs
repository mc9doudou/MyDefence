using UnityEngine;
namespace Solid
{
    //좌, 우회전하는 기능을 정의
    public interface ITurnable 
    {
        public void TurnLeft();
        public void TurnRight();

    }
}