using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public float powerPoint = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            Rigidbody enemy = collision.gameObject.GetComponent<Rigidbody>(); //  ���� ����Ѵ�.
            Vector3 collisionPoint = collision.contacts[0].point;             // �浹�� ��ġ�� ��ȯ
            Vector3 direction = (collisionPoint - transform.position).normalized; // �̵��� ���� 

            enemy.AddForce(direction * powerPoint, ForceMode.Impulse);
        }
    }
}
