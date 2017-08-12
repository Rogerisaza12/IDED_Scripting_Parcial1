using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField]
    private GameObject projectileToFire;

    [SerializeField]
    private Transform projectileSpawnTranform;

    public Rigidbody projectile;
    public float shotForce = 1000;

    public void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody shot;

            shot = Instantiate(projectile, projectileSpawnTranform.position, projectileSpawnTranform.rotation)as Rigidbody;
            shot.AddForce(projectileSpawnTranform.forward * shotForce);

            
        }
           
    }
}