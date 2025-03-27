using UnityEngine;

public class MoveTest : MonoBehaviour
{
    //�ʵ�
    //�̵��ӵ�
    private float speed = 5f;

    //�̵���ǥ ����

    Vector3 targetPosition = new Vector3(7f, 1f, 8f);       


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�÷��̾� ��ġ �������̵�
        //this.transform.position.z = this.transform.position.z + 1;
        //this.transform.position = this.transform.position + new Vector3(0f, 0f, 1f);
        //z(+,-)(��,��)   x(+,-)(��,��)  y(+,-)(��,�Ʒ�)
        //�� �� �� �� �� �Ʒ� 
        //this.transform.position = this.transform.position + new Vector3(1f, 0f, 0f);
        //this.transform.position = this.transform.position + new Vector3(-1f, 0f, 0f);
        //this.transform.position = this.transform.position + new Vector3(0f, 1f, 0f);
        //this.transform.position = this.transform.position + new Vector3(0f, -1f, 0f);
        //this.transform.position = this.transform.position + new Vector3(0f, 0f, -1f);

        //this.transform.position += Vector3.forward;
        //this.transform.position += Vector3.right;

        //������ 5�� �ӵ��� �̵�
        //�� �������� 1�ʿ� 1unit�� ��ŭ �̵�
        //this.transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * 1;
        //�� �������� 1�ʿ� 5unit�� ��ŭ �̵�
        //this.transform.position += Vector3.forward * Time.deltaTime * 5;

        //Translate : �̵� �Լ�
        //���� :�չ���
        //Time.deltaTime: ������ �ð��� ������ �Ÿ��� �̵��ϰ� ���ش�
        //speed : �̵��ӵ� - �ʴ� �̵��ϴ� �Ÿ�
        // Vector3 * float * float => Vector3
        //this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //�̵� ���� ���ϱ� : (��ǥ��ġ - ������ġ), (��ǥ��ġ - ������ġ).normalized
        //dir.magnitude : ������ ũ��, ����
        //dir.normalized : ���̰� 1�� ����, ����ȭ�� ����, ��������
        /*Vector3 dir = targetPosition - this.transform.position;
        transform.Translate(dir.normalized * Time.deltaTime * speed);*/

        //Space.World, Space.Self
        //transform.Translate(Vector3.forward * Time.deltaTime * speed,Space.Self);
        transform.Translate(Vector3.forward * Time.deltaTime * speed,Space.World);


    }
}
/*
1. ��,��,��,��� �̵��ϱ�
2. 5�� �ӵ��� �̵��ϱ�
3. ��ǥ����(7,1,8)���� �̵��ϱ�
4. ��ǥ���� ���� ����


1 unit
*/
/*
n ������ : �ʴ� n�� �����ϱ� (�����ֱ�)
20������ : 1������ �����ִµ� 0.05�� ���
FPS : 1�ʿ� (�����ϴ�)�����ִ� ������ ����

// unity 
1 Frame
Time.deltaTime : 1�������� �����ϴµ� �ɸ��� �ð� 


�ʴ� 20��ŭ �̵�
speed = 20;

PC1 : ���� 
144������ - 1�� 144��ŭ �̵�
Time.deltaTime: 1/144f(?)
this.transform.position += new Vector3(0f, 0f, -1f);


PC2 : ����    - ������ ����, ���
30������ - 1�� 30��ŭ �̵�
this.transform.position += new Vector3(0f, 0f, -1f);

�̵� ���� : ���� * �ӵ� * Time.deltaTime




*/