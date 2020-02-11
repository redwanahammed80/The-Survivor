using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapScript : MonoBehaviour
{
    public Transform FPSController;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = FPSController.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, FPSController.eulerAngles.y , 0f);


    }
}
