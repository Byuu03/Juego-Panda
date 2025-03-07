using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recursogpt : MonoBehaviour
{
    //public KeyCode pickupKey = KeyCode.E;
    //private BazokaScript currentWeapon;

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(pickupKey))
    //    {
    //        TryPickupWeapon();
    //    }

    //    // Si el jugador tiene un arma y presiona el botón de disparo
    //    if (currentWeapon != null && Input.GetButtonDown("Fire1"))
    //    {
    //        currentWeapon.Shooter();
    //    }
    //}

    //void TryPickupWeapon()
    //{
    //    // Raycast para detectar un arma cercana
    //    RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, 2f);
    //    if (hit.collider != null && hit.collider.CompareTag("Weapon"))
    //    {
    //        // Obtener el componente WeaponController del objeto
    //        BazokaScript weaponController = hit.collider.GetComponent<BazokaScript>();

    //        // Si encontramos un arma y el jugador no tiene un arma actualmente
    //        if (weaponController != null && currentWeapon == null)
    //        {
    //            // Configuramos el arma actual del jugador
    //            currentWeapon = weaponController;

    //            // Desactivamos el objeto del arma en la escena
    //            weaponController.gameObject.SetActive(false);
    //        }
    //    }
    //}

    //// Método para llamar cuando los disparos se agoten
    //public void WeaponOutOfAmmo()
    //{
    //    if (currentWeapon != null)
    //    {
    //        // Destruir el arma actual
    //        Destroy(currentWeapon.gameObject);

    //        // Restablecer la referencia al arma actual
    //        currentWeapon = null;
    //    }
    //}
}
