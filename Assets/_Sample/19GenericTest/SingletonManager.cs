using UnityEngine;
namespace Sample.Generic
{
    //SingletonManager �̱��� Ŭ����
    public class SingletonManager : Singleton<SingletonManager> 
    {
        //����
        public int number = 1234;
    }
}