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
            Rigidbody enemy = collision.gameObject.GetComponent<Rigidbody>(); //  힘을 사용한다.
            Vector3 collisionPoint = collision.contacts[0].point;             // 충돌한 위치를 반환
            Vector3 direction = (collisionPoint - transform.position).normalized; // 이동할 방향 

            enemy.AddForce(direction * powerPoint, ForceMode.Impulse);
        }
    }
}
