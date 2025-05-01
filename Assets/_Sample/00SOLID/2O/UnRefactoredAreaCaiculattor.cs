using UnityEngine;
namespace Solid
{
    //�簢�� Ŭ����
    public class Rectangle
    {
        public float width;
        public float height;
    }

    //�� Ŭ����
    public class Circle
    {
        public float radius;
    }

    //�ﰢ�� Ŭ���� 


    //������ ������ ���ϴ� Ŭ����
    public class UnRefactoredAreaCaiculattor : MonoBehaviour
    {
        //�Ű������� ���� �簢�� ������ ���� ���ؼ� ��ȯ�ϴ� �Լ�
        public float GetRectangleArea(Rectangle rectangle)
        {
            return rectangle.width * rectangle.height;
        }

        //�Ű������� ���� �� ������ ���� ���ؼ� ��ȯ�ϴ� �Լ�
        public float GetCircleArea(Circle circle)
        {
            return circle.radius * circle.radius * Mathf.PI;
        }

        //�Ű������� ���� �ﰢ�� ������ ���� ���ؼ� ��ȯ�ϴ� �Լ� 
        //...
    }
}