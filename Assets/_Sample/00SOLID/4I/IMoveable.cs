using UnityEngine;
namespace Solid.Interface
{
    public interface IMoveable
    {
        public float MoveSpeed { get; set; }
        public float Acceleation { get; set; }
        public void GoForward();
        public void GoBack();
        public void TurnLeft();
        public void TurnRight();

    }
}