using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    public float Speed 
    {
        get {return speed;}
        set {speed = value;}
    }
    private Rigidbody2D rb;

    private void OnEnable()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
       rb.linearVelocity = Vector3.down * speed;
    }
}
