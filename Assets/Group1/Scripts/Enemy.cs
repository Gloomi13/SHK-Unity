using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 Target;

    // Start is called before the first frame update
    void Start()
    {
        Tar();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target, 2 * Time.deltaTime);
        if (transform.position == Target)
            Tar();
    }

        void Tar()
    {
        Target = Random.insideUnitCircle * 4;
    }
}
