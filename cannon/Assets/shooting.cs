using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform shootPos;
    public GameObject sphere;
    public float shotPower;

    private void Update(){
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(sphere, shootPos.position, shootPos.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shotPower);
        }
    }
}
