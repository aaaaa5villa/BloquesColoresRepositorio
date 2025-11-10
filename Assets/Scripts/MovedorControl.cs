using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorControl : MonoBehaviour
{
    public Transform[] bloques;
    public Vector3[] direcciones;
    public MeshRenderer[] renderers;

    private void Awake()
    {
        if (renderers.Length == 4)
        {
            renderers[0].material.color = Color.red;

            renderers[1].material.color = Color.green;

            renderers[2].material.color = Color.blue;

            renderers[3].material.color = Color.yellow;
        }
        else
        {
            Debug.LogWarning("NO ha funcionado necesitas asignar mesrender al inspector");
        }
    }

    void Start()
    {
        direcciones = new Vector3[] { Vector3.right, Vector3.left, Vector3.right, Vector3.left };
    }

    void Update()
    {
        for (int i = 0; i < bloques.Length; i++)
        {
            //bloques[i].position += Vector3.right * Time.deltaTime;
            bloques[i].position += (i + 1) * direcciones[i] * Time.deltaTime;

            if (bloques[i].position.x < -4)
            {
                direcciones[i] = Vector3.right;
            }
            else if (bloques[i].position.x > 4)
            {
                direcciones[i] = Vector3.left;
            }
        }
    }
}