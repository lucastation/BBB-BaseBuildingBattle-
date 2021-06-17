using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnAlpha : MonoBehaviour
{/*
    public Transform placebale;
    public GameObject prefab;
    private BaseGrid grid;
    public int gridDimension = 100;
    public Material highlightMaterial;
    float range = 100;

    private void Start()
    {
        grid = new BaseGrid(gridDimension, gridDimension, gridDimension, 1f, new Vector3(0, 0, 0));

    }
    void Update()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(1))
        {
            if (placebale.position.x < 0 || placebale.position.y < 0 ||
                placebale.position.z < 0 || placebale.position.x > gridDimension || placebale.position.y > gridDimension || placebale.position.z > gridDimension)
            {
                Debug.Log("Cube out of grid");
            }
            else 

            {
                if (grid.getGridarray(placebale.position) != null)
                {
                    Debug.Log("Exista cub deja");
                }
                else
                {

                    
 

                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray, out hit, range))
            {
                Debug.Log(hit.point);
                var selection = hit.transform;
                var selectionRenderer = selection.GetComponent<Renderer>();
                if(hit.point!= null)
                {
                    Debug.Log(selectionRenderer.name);
                    selectionRenderer.material = highlightMaterial;
                    grid.SetValue(hit.point, prefab);
                    Instantiate(grid.getGridarray(hit.point), grid.GetWorldPosition(hit.point), Quaternion.Euler(0f, 0f, 0f));
                }
                else
                {
                    Debug.Log("Miss");
                }
            }
            Debug.Log("Click");
  
        }



    }*/
}
    