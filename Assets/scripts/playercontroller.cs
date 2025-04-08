using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float horizontalInput;
    public float xRange = 10.0f;
    public float speed = 10.0f;
    public GameObject projectileprefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
      { 
        //keep player in bounds
         if (transform.position.x < -xRange) 
      {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
      }
       if (transform.position.x > xRange) 
      {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
      }
         horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

       if (Input.GetKeyDown(KeyCode.Space))
      {
            // launch projectile
            Instantiate(projectileprefab, transform.position, projectileprefab.transform.rotation);
      }
      
      }

}
