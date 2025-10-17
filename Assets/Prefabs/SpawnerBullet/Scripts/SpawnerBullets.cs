using UnityEngine;

public class SpawnerBullets : MonoBehaviour
{

    [SerializeField]private GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("CreateBullet", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateBullet()
    {
        Instantiate(bullet,transform.position,transform.rotation);
    }
}
