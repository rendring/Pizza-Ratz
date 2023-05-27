using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBound : MonoBehaviour
{
    public Vector3 SpawnPoint;

    private void OnTriggerExit(Collider other){
        if (other.CompareTag("BoundObj")){
            other.gameObject.transform.position = SpawnPoint;
            other.attachedRigidbody.velocity = Vector3.zero;
            other.attachedRigidbody.angularVelocity = Vector3.zero;
        }
    }

}
