using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CannonController : MonoBehaviour
{

    private float _moveIncrement = .2f;
    private float cannonAngle = 0;
    private float cannonIncrement = 5.0f;
    private float _firePower = 20f;

    public Text _powerUI;

    public GameObject CannonballPrefab;
    public Transform CannonballSpawn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.parent.position += new Vector3(_moveIncrement, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.parent.position -= new Vector3(_moveIncrement, 0, 0);
        }
        /*
        if (Input.GetKey(KeyCode.UpArrow)) {
            cannonAngle += cannonIncrement;
            transform.rotation = Quaternion.Euler(0, 0, cannonAngle);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            cannonAngle -= cannonIncrement;
            transform.rotation = Quaternion.Euler(0, 0, cannonAngle);
        }
        */
    }

    public void CannonUp()
    {
        cannonAngle += cannonIncrement;
        transform.rotation = Quaternion.Euler(0, 0, cannonAngle);
        Debug.Log("Cannon Angle = " + cannonAngle);

    }

    public void CannonDown()
    {
        cannonAngle -= cannonIncrement;
        transform.rotation = Quaternion.Euler(0, 0, cannonAngle);
        Debug.Log("Cannon Angle = " + cannonAngle);
    }

    public void Fire()
    {
        // instantiate cannonball
        GameObject cannonball = Instantiate(CannonballPrefab, CannonballSpawn.position, Quaternion.identity) as GameObject;
        // figure out angle to shoot
        // Get a reference to the rigid body on the cannonball

        Rigidbody2D cannonballRigidbody = cannonball.GetComponent<Rigidbody2D>();
        //Get the direction that the ball should fly
        // Quaternion is a matrix and multiplying by the right vector. rotational
        Vector3 velocity = Quaternion.Euler(0, 0, cannonAngle) * Vector3.right ;
  
        velocity *= _firePower;

        // set velocity of the ball (which is in the rigid body component
        cannonballRigidbody.velocity = velocity;
    }

    public void FirePowerUp()
    {
        _firePower += 2;
        Debug.Log("Fire Power = " + _firePower);
    }

    public void FirePowerDown()
    {
        _firePower -= 2;
        Debug.Log("Fire Power = " + _firePower);
    }
}
