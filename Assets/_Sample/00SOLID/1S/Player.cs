using UnityEngine;
namespace Solid
{
    //�÷��̾� �����ϴ� Ŭ���� 
    public class Player : MonoBehaviour
    {
        #region Field
        private PlayerInput m_PlayerInput;
        private PlayerMovement m_PlayerMovement;
        private PlayerAudio m_PlayerAudio;
        private PlayerFX m_PlayerFX;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //����
            m_PlayerInput = this.GetComponent<PlayerInput>();
            m_PlayerMovement = this.GetComponent<PlayerMovement>();
            m_PlayerAudio = this.GetComponent<PlayerAudio>();
            m_PlayerFX = this.GetComponent<PlayerFX>();
        }

        // Update is called once per frame
        void Update()
        {
            //m_PlayerInput.HandleInput();
            //m_PlayerMovement.Move();
            //m_PlayerAudio.PlayRandomAudioClip();
            //m_PlayerFX.PlayEffect();
        }
    }
}