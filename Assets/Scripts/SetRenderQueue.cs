using UnityEngine;

public class SetRenderQueue : MonoBehaviour
{
    public int queue = 2002;

    void Start()
    {
        GetComponent<Renderer>().material.renderQueue = queue;
    }
}