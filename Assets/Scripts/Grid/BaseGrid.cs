using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGrid
{
    Vector3 originPosition;
    private int width;
    private int height;
    private int length;
    private float cellsize;
    public GameObject[,,] gridArray;

    public BaseGrid(int width, int height, int length, float cellsize, Vector3 originPosition)
    {
        this.originPosition = originPosition;
        this.width = width;
        this.height = height;

        this.cellsize = cellsize;

        gridArray = new GameObject[width, height, length];

/*        for(int x = 0; x < gridArray.GetLength(0); x++)
            for(int y = 0; y < gridArray.GetLength(1); y++)
                for(int z = 0; x < gridArray.GetLength(2); z++)
                {
                   // gridArray[x, y, z] = null;
                }*/
    }

    private Vector3 GetWorldPosition(int x, int y, int z)
    {
        return new Vector3(x, y, z) * cellsize + originPosition;
    }

    public Vector3 GetWorldPosition(Vector3 worldPosition)
    {
        return GetWorldPosition((int)worldPosition.x, (int)worldPosition.y, (int)worldPosition.z);
    }
    private void GetXYZ(Vector3 worldPosition, out int x, out int y, out int z)
    {
        x = Mathf.FloorToInt((worldPosition - originPosition).x / cellsize);
        y = Mathf.FloorToInt((worldPosition - originPosition).y / cellsize);
        z = Mathf.FloorToInt((worldPosition - originPosition).z / cellsize);

    }

    public void SetValue(int x, int y, int z, GameObject value)
    {

        //gridArray[x, y, z] = Instantiate(value, new Vector3(x, y, z), Quaternion.Euler(0f, 0f, 0f));
        gridArray[x, y, z] = value;

    }
    public void SetValue(Vector3 worldPosition, GameObject value)
    {
        int x, y, z;
        GetXYZ(worldPosition, out x, out y, out z);
        SetValue(x, y, z, value);
    }

    public GameObject getGridarray(int x,int y, int z)
    {
        return gridArray[x, y, z];
    }
    public GameObject getGridarray(Vector3 worldPosition)
    {
        return gridArray[(int)worldPosition.x, (int)worldPosition.y, (int)worldPosition.z];
    }


}
