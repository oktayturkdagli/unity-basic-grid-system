using UnityEngine;

public class Test : MonoBehaviour
{
    private Grid grid;

    private void Start()
    {
        grid = new Grid(20, 10, 1f, new Vector3(0, 0, 0));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(Utils.GetMousePositionIn3D(), 1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(Utils.GetMousePositionIn3D()));
        }
    }
}