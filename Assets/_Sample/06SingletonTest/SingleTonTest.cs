using UnityEngine;
namespace Sample
{
    //MonoBehaviour를 상속받은 클래스의 싱글톤 패턴
    public class SingleTonTest : MonoBehaviour
    {
        //클래스의 인스턴스 변수를 정적(static)변수로 선언 
        private static SingleTonTest instance;
        
        public static SingleTonTest Instance
        {
            get
            {
                
                return instance;
            }
        }

        private void Awake()
        {
            if(instance != null)
            {
                Destroy(gameObject);
                return;
            }
            instance = this;

            //씬 종료시 오브젝트 삭제 금지
            DontDestroyOnLoad(gameObject);
        }
        //필드
        public int number;

    }
}