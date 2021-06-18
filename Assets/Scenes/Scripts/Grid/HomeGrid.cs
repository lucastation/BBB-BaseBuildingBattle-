using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeGrid : MonoBehaviour
{
    [SerializeField]
    private int width = 50, height = 50, length = 50;
    private BaseGrid homeGrid;


    public void CreateGrid()
    {
        homeGrid = new BaseGrid(width, height, length, this.transform.position);
    }
}
