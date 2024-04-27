using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float bulletSpeed = 10f;

    public void ShootBullet()
    {
       GameObject spawnBullet = Instantiate(Bullet, spawnPoint.position, spawnPoint.rotation);
        spawnBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;
        Destroy(spawnBullet, 3f);

    }
}
