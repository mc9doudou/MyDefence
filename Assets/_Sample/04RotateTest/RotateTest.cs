using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
namespace Sample
{
    public class RotateTest : MonoBehaviour
    {
        #region field
        private float x;
        //ȸ���ӵ�
        public float turnSpeed = 5f;
        //�̵��ӵ�
        public float moveSpeed = 5f;

        //Ÿ�� ������Ʈ
        public Transform target;

        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //this.gameObject
            //this.transform.rotation = Quaternion.Euler(90f, 0f, 0f);    //x�� ���� ȸ��
            //this.transform.rotation = Quaternion.Euler(0f, 90f, 0f);    //y�� ���� ȸ��
            //this.transform.rotation = Quaternion.Euler(0f, 0f, 90f);    //z�� ���� ȸ��
        
        
        }

        // Update is called once per frame
        void Update()
        {
            //y�� �������� +���� ȸ���ϱ� 
            x += 1;
            //this.transform.rotation = Quaternion.Euler(0f, x, 0f);
            //y������ + ȸ��
            //this.transform.rotation = Quaternion.Euler(x, 0f, 0f);
            //x������ + ȸ��
            //this.transform.rotation = Quaternion.Euler(0f, 0f, x);
            //z������ + ȸ��

            //y��������� �ӵ� 5�� ȸ��
            //x += Time.deltaTime * 5;
            //this.transform.rotation = Quaternion.Euler(0f, x, 0f);

            // �� ��������  turnSpeed�ӵ� ȸ��
            //this.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
            //this.transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed);
            //this.transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed);

            //Ÿ�� ������Ʈ �߽����� ȸ���ϱ�
            //transform.RotateAround(target.transform.position, Vector3.up, 360 * Time.deltaTime);

            /* //���ϴ� �������� ȸ���ϱ� 
             //Vector3 dir = Ÿ����ġ - ������ġ;
             Vector3 dir = target.position - this.transform.position;
             //���� vector�� ���� target���� ���� ȭ���� ���ϱ�
             Quaternion targetRotation = Quaternion.LookRotation(dir);
             //transform.rotation = lookRotation;
             //this.transform.rotation = lookRotation; 
             Quaternion lookRotation = Quaternion.Lerp(this.transform.rotation,targetRotation,Time.deltaTime*turnSpeed);
             Vector3 eulerRotation = lookRotation.eulerAngles; // eulerRotation.x, eulerRotation.y, eulerRotation.z
             //y�࿬���� ���� Euler�� ������ 

             //Euler������ Quaternion(���ʹϾ�)�� ���ϱ�
             this.transform.rotation = Quaternion.Euler(0f,eulerRotation.y,0f);*/

            //ȸ�� + �̵�
            //Ÿ�� ���� ���ϱ�
            Vector3 dir = target.position - this.transform.position;
            //���� vector�� �ٶ󺸴� ȭ���� �����ϱ�
            this.transform.rotation = Quaternion.LookRotation(dir);
            this.transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);
            //this.transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.Self);

        }
    }
}
/*
Quaternion(���ʹϾ�)
Euler(���Ϸ�)

[1]Euler(���Ϸ�)������ Quaternion(���ʹϾ�)�� ���ϱ�
3�ڸ����� 4�ڸ� �� ���ϱ�
Quaternion �� = Quaternion.Euler (Euler X, Euler Y, Euler Z);

[2]Quaternion(���ʹϾ�)������ Euler(���Ϸ�)�� ���ϱ�
4�ڸ����� 3�ڸ� �� ���ϱ�
Vector3 angles = Quaternion(transform.rotation).eulerAngles;
*/