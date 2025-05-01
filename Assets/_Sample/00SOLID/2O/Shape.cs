using UnityEngine;

namespace Solid.OpenClose
{
    //모든 도형의 부모 클라스
    public abstract class Shape 
    {
        //도형의 면적을 구해서 반환하는 함수
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