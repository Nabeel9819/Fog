using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public GameObject point;
    public Rigidbody rig;

    private void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstical")
        {
            movement.enabled = false;
            movement.Forward_Force = 0; 
            rig.freezeRotation  = true;
            rig.angularDrag = 5;
            FindObjectOfType<GameManage>().EndGame();
            
        }

        if (collisionInfo.collider.tag == "Point")
        {
            Points.Score += 1;

            Destroy (collisionInfo.gameObject);
        }

    }

}
