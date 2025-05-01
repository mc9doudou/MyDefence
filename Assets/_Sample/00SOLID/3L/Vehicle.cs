using UnityEngine;
namespace Solid
{
    //Ż�� ��� ���� Ŭ����
    public class Vehicle : MonoBehaviour
    {
        #region Field
        public float speed;
        public Vector3 direction;
        #endregion
        
        public virtual void GoForward()
        {
            //������ ���� ����
        }

        public virtual void GoBack()
        {
            //�ڷ� ���� ���� 
        }

        public virtual void Turnleft()
        {
            //��ȸ�� ����
        }

        public virtual void Turnright()
        {
            //��ȸ�� ����
        }
    }

    //Vehicle�� ��ӹ��� Car Ŭ����
    public class Car : Vehicle
    {
        public override void GoForward()
        {
            //�ڵ����� �����Ѵ� ����
            //base.GoForward();
        }

        public override void GoBack()
        {
            //�ڵ����� �����Ѵ� ����
            //base.GoBack();
        }

        public override void Turnleft()
        {
            //�ڵ����� ��ȸ�� �Ѵ�
            //base.Turnleft();
        }

        public override void Turnright()
        {
            //�ڵ����� ��ȸ�� �Ѵ�
            //base.Turnright();
        }
    }

    public class train : Vehicle
    {
        public override void GoForward()
        {
            //�ڵ����� �����Ѵ� ����
        }

        public override void GoBack()
        {
            //�ڵ����� �����Ѵ� ����
        }

        public override void Turnleft()
        {
            //empty
        }
        private void Update()
        {
            Turnleft();
            Turnright();
        }

    }



}