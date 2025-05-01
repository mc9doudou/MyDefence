using UnityEngine;
namespace Sample.Generic
{
    //SingletonManager ½Ì±ÛÅæ Å¬·¡½º
    public class SingletonManager : Singleton<SingletonManager> 
    {
        //º¯¼ö
        public int number = 1234;
    }
}