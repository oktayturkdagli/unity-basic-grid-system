using UnityEngine;

public class Test : MonoBehaviour
{
    private Grid<bool> grid;

    private void Start()
    {
        grid = new Grid<bool>(20, 10, 10f, new Vector3(0, 0, 0));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(Utils.GetMousePositionIn3D(), true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(Utils.GetMousePositionIn3D()));
        }
    }
}