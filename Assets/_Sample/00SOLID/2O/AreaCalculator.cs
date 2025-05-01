using UnityEngine;
namespace Solid.OpenClose
{
    public class AreaCalculator : MonoBehaviour
    {
        public Rectangle rectangle;
        public Circle circle;

        //�Ű������� �޴� ������ ���� ���ؼ� ��ȯ�ϴ� �Լ�
        public float GetShapeArea(Shape shape)
        {
            return shape.CaculateArea();
        }

        private void Start()
        {
            float rectarea = GetShapeArea(rectangle);
            float circlearea = GetShapeArea(circle);
            
        }

        //�Ű������� ���� �簢�� ������ ���� ���ؼ� ��ȯ�ϴ� �Լ�
        public float GetRectangleArea(Rectangle rectangle)
        {
            return rectangle.CaculateArea();
        }


        //�Ű������� ���� �� ������ ���� ���ؼ� ��ȯ�ϴ� �Լ�
        public float GetCircleArea(Circle circle)
        {
            return circle.CaculateArea();
        }


        //�Ű������� ���� �ﰢ�� ������ ���� ���ؼ� ��ȯ�ϴ� �Լ� 


    }
}