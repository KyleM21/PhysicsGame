using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnBounce : MonoBehaviour
{
    // Start is called before the first frame update
    Color[] cols = new Color[8];
    int idx;
    float absTime;
    Renderer ren;
    void Start()
    {
        cols[0] = new Color32(0x48, 0x85, 0xf4, 0xff); // deep blue
        cols[1] = new Color32(0x00, 0xa1, 0xf1, 0xff); // light blue
        cols[2] = new Color32(0x34, 0xa8, 0x53, 0xff); // teal
        cols[3] = new Color32(0x7c, 0xbb, 0x00, 0xff); // forest green
        cols[4] = new Color32(0xfb, 0xbc, 0x05, 0xff); // poop yellow
        cols[5] = new Color32(0xff, 0xbb, 0x00, 0xff); // slightly less poop yellow
        cols[6] = new Color32(0xea, 0x43, 0x35, 0xff); // red
        cols[7] = new Color32(0xf6, 0x53, 0x14, 0xff); // orange

        ren = gameObject.GetComponent<Renderer>();

        idx = Mathf.RoundToInt(Random.Range(0, 8));
        ren.material.SetColor("_Color", cols[idx]);
    }

    // Update is called once per frame
    void Update()
    {
        absTime += Time.deltaTime;
        if (absTime > 1)
        {
            idx = Mathf.RoundToInt(Random.Range(0, 8));
            ren.material.SetColor("_Color", cols[idx]);
            absTime = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > 5 && absTime > 0.4f)
        {
            idx = Mathf.RoundToInt(Random.Range(0, 8));
            ren.material.SetColor("_Color", cols[idx]);
            absTime = 0;
        }
    }
}
