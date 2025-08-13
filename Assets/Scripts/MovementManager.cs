using System.Collections;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class MovementManager : MonoBehaviour
{

    // bir noktadan baska bir noktaya courouitine kullanarak hareket etme.
    public Transform target;
    public float moveduration = 2f;

    private void Start()
    {
        StartCoroutine(MoveRouitine(target.position, moveduration));
    }


    
        IEnumerator MoveRouitine(Vector3 targetpos, float time)
        {
            Vector3 startposition = transform.position;
            float passedtime = 0f;
            while (passedtime < time)
            {
                transform.position = Vector3.Lerp(transform.position, target.position, passedtime / time);
                passedtime += Time.deltaTime;
                yield return null;// 2 kare arasindaki gecen sure kadar beklemeyek icin kullaniliyor.
            }
            // hedef pozisyona ulasma.
            transform.position = targetpos;
        }
    
    



















    /* 
        //2 nokta arasinda smooth harekete yariyan yapi.

        public Transform target;
        public float speed = 2f;

        void Update()
        {
            transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);// belirlenen hedefe smooth bir sekilde hareket edilmesi icin kullanilir.
        }
     */





    /*     //Vector3.MoveTowards duz bir cizgide sabit bir hiz saglar.

        public Transform[] Targets;
        public float speed = 5f;

        int currentindex = 0;
        private void Update()// sectigimiz hedefler arasinda teker teker gitmesini saglayan kod.
        {
            if (currentindex < Targets.Length)
            {
                transform.position = Vector3.MoveTowards(transform.position, Targets[currentindex].position, speed * Time.deltaTime);
                if (transform.position == Targets[currentindex].position)
                {
                    currentindex++;
                }
            }

        }
            */




    /* 
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
rb.AddForce(Vector3.up * force,ForceMode.Force);                // yukari yonlu guc uygular.
/* 
FORCE MODS        (ForceMode.*****)
-force = Devamli kuvvet uygular.
-Impulse = Anlik kuuvet uygular. Hizda ani bir degisiklik yapar. 
-VelocityChange = Nesnenin hizimi dogrudan degistirir. 
-Acceleration = Kutleden bagimsiz bir ivme uygular.




//rb.linearVelocity = new Vector3(5, 0, 0);        // ulastigimiz rigidbody nin hiz parametresi ile ilgili islem yapiyoruz.



}
}



*/











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