using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var mousePos = Input.mousePosition;
            var ray = Camera.main.ScreenPointToRay(mousePos);

            if(Physics.Raycast(ray, out hit))
            {
                var currentObject = hit.collider.gameObject;
                var force = -hit.normal * 5f;
                currentObject.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);

                Destroy(currentObject, 0.1f);
            }
        }
    }
}
