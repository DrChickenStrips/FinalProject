using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform player; 
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
