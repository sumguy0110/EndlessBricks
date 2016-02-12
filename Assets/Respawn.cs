using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
    

    // Use this for initialization
    void Start ()
    {
            
    }


    // Update is called once per frame
    void Update ()
    {
        RaycastHit2D respawnCast = Physics2D.Raycast(transform.position, Vector2.right);
        if (respawnCast.collider != null)
        {
            Debug.Log("Respawn");
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    
}
