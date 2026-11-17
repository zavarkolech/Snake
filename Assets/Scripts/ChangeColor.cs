
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private MeshRenderer _mesh;

    private void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.F))
        _mesh.material.color = Color.blue;

        if(Input.GetKeyUp(KeyCode.G))
        _mesh.material.color = Color.red;

        if(Input.GetKeyUp(KeyCode.H))
        _mesh.material.color = Color.green;
    } 
}
