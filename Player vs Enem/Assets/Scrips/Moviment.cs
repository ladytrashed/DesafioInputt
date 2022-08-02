using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public Vector3 direction = new Vector3(0f, 0f, 1f);
    public float speed = 2f;
    public float liveTime = 3f;
    public float localScale;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyDelay", liveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        // transform.position += direction * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.localScale = new Vector3(2f, 2f, 2f);
    }
    private void DestroyDelay()
    {
        Debug.Log("DESTROY DELAY");
        Destroy(gameObject);
    }
}
