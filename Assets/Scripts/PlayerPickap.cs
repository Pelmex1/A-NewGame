using System.Collections;
using UnityEngine;

public class PlayerPickap : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float minZ;
    [SerializeField] private float maxX;
    [SerializeField] private float maxZ;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "stick")
        {
            collision.gameObject.SetActive(false);
            StartCoroutine(enableStick(collision.gameObject));
        }
    }
        private IEnumerator enableStick(GameObject targetObject){
        targetObject.transform.position = Teleportpositions(targetObject.transform.position);
        targetObject.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
    }
    private Vector3 Teleportpositions(Vector3 positionNow){
        float randomX,randomZ;
        randomX = Random.Range(minX,maxX); randomZ = Random.Range(minZ,maxZ);
        Vector3 newPosition = new Vector3(positionNow.x + randomX,positionNow.y,positionNow.z + randomZ);
        return newPosition;
    }
}
