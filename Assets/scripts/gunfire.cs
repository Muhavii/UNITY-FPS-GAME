using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunfire : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource gunshot;
    private bool hasGunFire = false;
    [SerializeField] float gunFireDelay;
    void Start()
    {
        gunshot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(hasGunFire == false)
            {
                StartCoroutine(FireGun());
            }
        }
        }
    IEnumerator FireGun()
    {
        hasGunFire = true;
        gunshot.Play();
        yield return new WaitForSeconds(gunFireDelay);
        hasGunFire = false;
    }

    }
