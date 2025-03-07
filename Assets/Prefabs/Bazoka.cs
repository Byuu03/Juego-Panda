using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazoka : MonoBehaviour
{
    //ACTIVADOR DE GANCHO
    public GameObject gancho;

    //DESACTIVADOR DE ARMAS
    public GameObject armaADesactivar;

    public GameObject balas;
    public Transform shotPoint;
    public float bulletForce;

    public float fireRate;
    float nextFire;

    public int maxShots;
    int shotsFire;

    //public Animator animato;

    [Header("Boton")]
    public KeyCode bang;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(bang))
        {
            Shoot();
            //animato.SetBool("enShot", true);
        }

        if (Input.GetKeyUp(bang))
        {
            //animato.SetBool("enShot", false);
        }

    }

    public void Shoot()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            GameObject bullet = Instantiate(balas, shotPoint.position, shotPoint.rotation) as GameObject;
            bullet.GetComponent<Rigidbody2D>().AddForce(shotPoint.right * bulletForce, ForceMode2D.Impulse);

            shotsFire++;

            if (shotsFire == maxShots)
            {
                armaADesactivar.SetActive(false);
                //print("Se acabaron los disparos");

                //gancho.SetActive(true);

                gancho.transform.rotation = Quaternion.Euler(0, 0, 0);

                Invoke("ResetShots", 0.2f);
            }

        }



    }

    void ResetShots()
    {
        shotsFire = 0;
    }
}
