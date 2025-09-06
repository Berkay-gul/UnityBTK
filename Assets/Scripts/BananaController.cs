using UnityEngine;

public class BananaController : MonoBehaviour
{

    public float movespeed = 5f;
    Vector3 move = Vector3.zero;

    public void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move += Vector3.back;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move += Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move += Vector3.left;
        }

        transform.Translate(move * movespeed * Time.deltaTime);
    }

























    /* // Update is called once per frame
    // GetKey --> Tusa basili tutuldugunda calisir.
    // GetKeyDown --> Tusa basildiginda calisir.
    //GetKeyUp --> Tustan elimizi cektigimizde calisir.
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("tusa basildi");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("tusa basiliyor");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("tustan elimizi cektik ");
        }
    } */
}
