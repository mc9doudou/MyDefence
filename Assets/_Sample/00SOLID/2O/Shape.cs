using UnityEngine;

namespace Solid.OpenClose
{
    //��� ������ �θ� Ŭ��
    public abstract class Shape 
    {
        //������ ������ ���ؼ� ��ȯ�ϴ� �Լ�
        public abstract float CaculateArea();
    }

    public class Rectangle: Shape
    {
        public float width;
        public float heigth;

        public override float CaculateArea()
        {
            return width * heigth;
        }
    }
    public class Circle : Shape
    {
        public float radius;
        public override float CaculateArea()
        {
            return radius * radius * Mathf.PI;
        }

    }


}