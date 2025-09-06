using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
   
    public float speed = 1f;
    Vector3 movement;

    // Update is called once per frame
    void Update()
    {   // unity nin kendi hareket sistemini kullanmamizi saglayan kod parcasu
        float hzInput = Input.GetAxis("Horizontal");
        float vzInput = Input.GetAxis("Vertical");

        movement= new Vector3(hzInput,0, vzInput);
        transform.Translate(movement*speed*Time.deltaTime);
    }
}
