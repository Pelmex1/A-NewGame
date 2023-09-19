using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickap : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("test");
        if(collision.gameObject.tag == "stick"){
            collision.gameObject.SetActive(false);
            StartCoroutine(enableStick(collision.gameObject));
        }
    }
    private IEnumerator enableStick(GameObject targetObject){
        Debug.Log("startCorotine");
        targetObject.transform.position = Teleportpositions(targetObject.transform.position);
        targetObject.SetActive(true);
        yield return new WaitForSeconds(100);
    }
    private Vector3 Teleportpositions(Vector3 positionNow){
        float randomX,randomZ;
        randomX = Random.Range(-20,28.99f); randomZ = Random.Range(-24,25);
        Vector3 newPosition = new Vector3(positionNow.x + randomX,positionNow.y,positionNow.z + randomZ);
        return newPosition;
    }
}
