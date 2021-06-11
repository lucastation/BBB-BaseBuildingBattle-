using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Transform ObjToMove;
    public GameObject ObjToPlace;
    public LayerMask mask;
    int LastPosX, LastPosY, LastPosZ;


    void Update()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;

        
        if (Physics.Raycast(ray, out hit, 100, mask)) 
        {

            int PosX = (int)Mathf.Round(hit.point.x);
            int PosY = (int)Mathf.Round(hit.point.y);
            int PosZ = (int)Mathf.Round(hit.point.z);

            
            if (PosX != LastPosX || PosY != LastPosY || PosZ != LastPosZ )
            {
                LastPosX = PosX;
                LastPosY = PosY;
                LastPosZ = PosZ;
                ObjToMove.position = new Vector3(PosX, PosY, PosZ);

             }
            if (Input.GetMouseButtonDown(0))
                Instantiate(ObjToPlace, ObjToMove.position, Quaternion.identity);
        }

    
    }
}
