using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Transform ObjToMove;
    public GameObject ObjToPlace;
    public LayerMask mask;
    int LastPosX, LastPosY, LastPosZ;

    private BaseGrid homeGrid;

    private void Start()
    {
        homeGrid = new BaseGrid(100, 100, 100, new Vector3(0, 0, 0));
    }

    void Update()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, 100, mask)) 
        {


            int PosX = (int)Mathf.Round(hit.point.x);
            int PosY = (int)Mathf.Round(hit.point.y);
            int PosZ = (int)Mathf.Round(hit.point.z);


            if (Mathf.Abs(hit.point.x % 1) == 0.5f)
            {
                Debug.Log("X works");
                PosX = (int)Mathf.Round(hit.point.x + (Mathf.Sign(this.transform.position.x - hit.point.x) * 0.2f));
            }
            else if (Mathf.Abs(hit.point.y % 1) == 0.5f)
            {
                Debug.Log("Y works");
                PosY = (int)Mathf.Round(hit.point.y + (Mathf.Sign(this.transform.position.y - hit.point.y) * 0.2f));
            }
            else if (Mathf.Abs(hit.point.z % 1f) == 0.5f)
            {
                Debug.Log("Z works");
                PosZ = (int)Mathf.Round(hit.point.z + (Mathf.Sign(this.transform.position.z - hit.point.z) * 0.2f));
            }

            Debug.Log("Hitpoints" + " X: " + hit.point.x + " Y: " + hit.point.y + " Z: " + hit.point.z);


            Debug.Log(PosX + " " + PosY + " " + PosZ);


            if (PosX != LastPosX || PosY != LastPosY || PosZ != LastPosZ )
            {
                LastPosX = PosX;
                LastPosY = PosY;
                LastPosZ = PosZ;
                ObjToMove.position = new Vector3(PosX, PosY, PosZ);

             }

            if (Input.GetMouseButtonDown(1))
            {
                homeGrid.SetValue(ObjToMove.position, ObjToPlace);
                Instantiate(ObjToPlace, homeGrid.GetWorldPosition(ObjToMove.position), Quaternion.identity);
            }

            if (Input.GetMouseButtonDown(0))
            {
                //homeGrid.DeleteValue(ObjToMove.position);
                // Destroy(hit.collider.gameObject);
                Block target = hit.transform.GetComponent<Block>();

                if(target != null)
                {
                    target.TakeDamage(50);
                }
            }

            
        }

    

    }
}
