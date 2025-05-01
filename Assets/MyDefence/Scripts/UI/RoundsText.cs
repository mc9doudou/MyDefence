using System.Collections;
using TMPro;
using UnityEngine;
namespace MyDefence
{
    //���� ���� ī���� �ִϸ��̼� ����
    public class RoundsText : MonoBehaviour
    {
        #region Field
        public TextMeshProUGUI roundText;
        #endregion

        private void OnEnable()
        {
            //�ִ� ���� ����
            StartCoroutine(AnimateNumberText(PlayerStats.Rounds));
        }

        //�Ű������� ���� ���ڸ� UI�ؽ�Ʈ���� �ִϸ��̼� ����
        IEnumerator AnimateNumberText(int targetNumber)
        {
            int aniNumber = 0;
            roundText.text = aniNumber.ToString();
            yield return new WaitForSeconds(0.1f);

            while (aniNumber < targetNumber)
            {
                aniNumber++;
                roundText.text = aniNumber.ToString();
                yield return new WaitForSeconds(0.05f);
            }

            //�ִ� ���� ����

        }

    }
}