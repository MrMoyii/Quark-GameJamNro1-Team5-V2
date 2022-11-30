using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    Vector3 cameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraNewPosition  = player.transform.position;

        float jumpYPosition = cameraPosition.y + cameraNewPosition.y  ;

        gameObject.transform.position = new Vector3(cameraPosition.x, jumpYPosition, cameraNewPosition.z);
    }
}
