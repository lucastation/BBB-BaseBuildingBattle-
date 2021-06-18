using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayCasting : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript;

    [SerializeField]
    LayerMask mask;

    [SerializeField]
    Camera cam;

    private int LastPosX, LastPosY, LastPosZ;

    [SerializeField]
    Transform ObjToMove;

    private void Update()
    {
        var ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100, mask))
        {
            int PosX = (int)Mathf.Round(hit.point.x);
            int PosY = (int)Mathf.Round(hit.point.y);
            int PosZ = (int)Mathf.Round(hit.point.z);

            if (Mathf.Abs(hit.point.x % 1) == 0.5f)
            {
                PosX = (int)Mathf.Round(hit.point.x + (Mathf.Sign(cam.transform.position.x - hit.point.x) * 0.2f));
            }
            else if (Mathf.Abs(hit.point.y % 1) == 0.5f)
            {
                PosY = (int)Mathf.Round(hit.point.y + (Mathf.Sign(cam.transform.position.y - hit.point.y) * 0.2f));
            }
            else if (Mathf.Abs(hit.point.z % 1f) == 0.5f)
            {
                PosZ = (int)Mathf.Round(hit.point.z + (Mathf.Sign(cam.transform.position.z - hit.point.z) * 0.2f));
            }

            if (PosX != LastPosX || PosY != LastPosY || PosZ != LastPosZ)
            {
                LastPosX = PosX;
                LastPosY = PosY;
                LastPosZ = PosZ;
                ObjToMove.position = new Vector3(PosX, PosY, PosZ);

            }
        }


    }


}
