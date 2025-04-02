using UnityEngine;
namespace Sample
{
    public class SingleTon
    {
        //클래스의 인스턴스를 정적(static) 변수 선언
        private static SingleTon instance;

        public static SingleTon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingleTon();
                }
                return instance;
            }
        }

        //public한 메서드로 instance를 전역적으로 접근하기
        /*public static SingleTon Instance()
        {
            if (instance == null)
            {
                instance = new SingleTon();
            }
            return instance;
        }*/

        /*
        생성자 
        public SingleTon()
        {
        
        }
        */
    }
}
/*
 싱클톤 클래스 패턴
하나의 인스턴스만 존재 : new를 1번만 호출
클래스의 인스턴스가 전역적 접근 가능 : 변수 static 선언

1. Singleton의 특징
 전역 접근 가능: 어디서든 인스턴스를 쉽게 접근할 수 있음.
 메모리 절약: 불필요한 객체 생성을 막고, 하나의 인스턴스를 공유.
 객체 간 데이터 공유: 여러 스크립트에서 동일한 인스턴스를 사용.
*/