using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGrid
{
    Vector3 originPosition;
    private int width;
    private int height;
    private int length;
    public GameObject[,,] gridArray;

    public BaseGrid(int width, int height, int length, Vector3 originPosition)
    {
        this.originPosition = originPosition;
        this.width = width;
        this.height = height;

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
        return new Vector3(x, y, z) + 0 * originPosition;
    }

    public Vector3 GetWorldPosition(Vector3 worldPosition)
    {
        return GetWorldPosition((int)worldPosition.x, (int)worldPosition.y, (int)worldPosition.z);
    }
    private void GetXYZ(Vector3 worldPosition, out int x, out int y, out int z)
    {
        x = Mathf.FloorToInt((worldPosition - originPosition).x);
        y = Mathf.FloorToInt((worldPosition - originPosition).y);
        z = Mathf.FloorToInt((worldPosition - originPosition).z);

    }   

    public void SetValue(int x, int y, int z, GameObject value)
    {
        gridArray[x, y, z] = value;
    }
    public void SetValue(Vector3 worldPosition, GameObject value)
    {
        int x, y, z;
        GetXYZ(worldPosition, out x, out y, out z);
        SetValue(x, y, z, value);
    }
    public void DeleteValue(int x, int y, int z)
    {
        gridArray[x, y, z] = null;
    }
    public void DeleteValue(Vector3 worldPosition)
    {
        int x, y, z;
        GetXYZ(worldPosition, out x, out y, out z);
        DeleteValue(x, y, z);
    }
}
