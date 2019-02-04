using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee: MonoBehaviour {
   // public AudioClip soundToPlay;
    public float HitTime;
    public float sliceSpeed;
    public float fireSpeed;
    float timer = 0;
    public GameObject prefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
         
        /*if (Input.GetButton("Fire1") && timer > fireSpeed)
        {
            timer = 0;
            
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;
            Vector3 hitDir = mousePosition - transform.position;
            hitDir.Normalize();
            //shootDir *= bulletSpeed;
            //destination - start pos.
            GameObject MeleeHitbox = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
            MeleeHitbox.GetComponent<Rigidbody2D>().velocity = hitDir.normalized * sliceSpeed;
            Destroy(MeleeHitbox, HitTime);
           // Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);

        }*/
	}
    public void Attack()
    {
        if (timer > fireSpeed)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;
            Vector3 hitDir = mousePosition - transform.position;
            hitDir.Normalize();
            //shootDir *= bulletSpeed;
            //destination - start pos.
            GameObject MeleeHitbox = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
            MeleeHitbox.GetComponent<Rigidbody2D>().velocity = hitDir.normalized * sliceSpeed;
            Destroy(MeleeHitbox, HitTime);
            timer = 0;
        }
    }
}
