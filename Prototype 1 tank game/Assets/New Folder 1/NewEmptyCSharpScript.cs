using UnityEngine;

public class NewEmptyCSharpScript
{
    public float speed;
    public float rotspeed;
    public float hInput;
    public float vInput;
    public float jumpforce;
    public Rigidbody playerRB;

    // Update is called once per frame
    void Update ()
    {
        hInput = Input.GetAxiis("Horizontal");
        vInput = Input.GetAxiis("Vertical");

        Transform.Rotate(Vector3.right*hInput*speed*Time.DeltaTime)//move the vehicle left and right(side-to-side)
        Transform.Translate(Vector3.forwar*vInput*speed*Time.Deltatime)//tge vehicle
    }
}
