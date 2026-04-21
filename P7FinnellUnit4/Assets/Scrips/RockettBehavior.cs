using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class RockettBehavior : MonoBehaviour
{
    private Transform target;
    private float speed = 15.0f;
    private bool homing;

    private float rocketStrength = 15.0f;
    private float aliveTimer = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Fire(Transform newTarget)
    {
        ;
        homing = true;
        Destroy(gameObject, aliveTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
