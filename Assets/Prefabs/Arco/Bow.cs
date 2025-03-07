using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    //GANCHO
    public GameObject ganchar;

    public GameObject desactivadorDeArma;

    public GameObject arrow;
    public float launchforce;
    public Transform shotPoint;

    //public GameObject point;
    //GameObject[] points;
    //public int numberOfPoints;
    //public float spaceBetweenPoints;

    public float fireRate;
    float nextFire;

    public int maxShots;
    int shotsFire;

    public Animator animat;

    //Vector2 direction; //

    [Header("Keybinds")]
    public KeyCode shotKey;

    // Start is called before the first frame update
    void Start() //
    {
        //points = new GameObject[numberOfPoints];
        //for (int i = 0; i < numberOfPoints; i++)
        //{
        //    points[i] = Instantiate(point, shotPoint.position, Quaternion.identity);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shotKey))
        {
            LaunchShoot();
            animat.SetBool("onShot", true);
        }
        if (Input.GetKeyUp(shotKey))
        {
            animat.SetBool("onShot", false);
        }

        //for (int i = 0; i < numberOfPoints; i++) //
        //{
        //    points[i].transform.position = PointPosition(i * spaceBetweenPoints);
        //}
    }

    void LaunchShoot()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
            newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchforce;

            shotsFire++;

            if (shotsFire == maxShots)
            {
                desactivadorDeArma.SetActive(false); //ACAAAAA
                //print("Se acabaron los disparos");
                ganchar.SetActive(true);

                Invoke("ReseetShots", 0.2f);
            }
        }

        //GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
        //newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchforce;
    }

    //Vector2 PointPosition(float t) //
    //{
    //    Vector2 position = (Vector2)shotPoint.position + (direction.normalized * launchforce * t) + 0.5f * Physics2D.gravity * (t * t);
    //    return position;
    //}

    void ReseetShots()
    {
        shotsFire = 0;
    }

}
