using UnityEngine;

public class MovementManager : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 10f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();                     //Ayni nesnedeki rigidbody componentine erismemeizi saglayan kod.
    }
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Space))                // space tusuna basildiginda aktiflesecek sorgu.
        {
            rb.AddForce(Vector3.up * force);                // yukari yonlu guc uygular.
        }
        //rb.linearVelocity = new Vector3(5, 0, 0);        // ulastigimiz rigidbody nin ivme parametresi ile ilgili islem yapiyoruz.
    }















    /*  public float moveSpeed = 5f;
                   public Vector3 Movement = Vector3.zero;

                   void Start()
                   {
                       //transform.position = new Vector3(5f, transform.position.y, transform.position.z);//trasnform.position ile verdigimiz degerler sabit kaliyor, nesnenin konumunuu direk olarak degistirmeye yarayan fonksyon.
                   }


                   void Update()
                   {
                       //Surekli olarak belirli yonde belirli kuveetle konum degistirmeye yariyor.
                       //transform.position = transform.position + new Vector3(1f, 0, 0); 
                       //transform.position += new Vector3(1, 0, 0)*moveSpeed*Time.deltaTime; 
                       //transform.position += Vector3.right * moveSpeed * Time.deltaTime;
                       transform.Translate(Movement * moveSpeed * Time.deltaTime);


                   } */
}
//time.deltatime == bir frame in islenmesi icin gecen sureyi saniye cinsinden veriri yani 60 fps aliyorsak 1/60 saniye degerini elde ederir.
//Islemlerin frame rate e bagli oalrak uyguklanmasinin onune gecer her kare sayisinda ayni sonucu aliriz.