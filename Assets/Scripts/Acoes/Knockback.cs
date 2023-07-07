using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    [Header("Tag do gameObject que receberá o Knockback")]
    public string outroTag;
    public float knockbackForce;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag(outroTag))
        {
            print("Deu knockback");
            Vector2 difference = (transform.position - outro.transform.position).normalized;
            Vector2 force = difference * knockbackForce;
            rb.AddForce(force / rb.mass / Time.fixedDeltaTime); //if you don't want to take into consideration enemy's mass then use ForceMode.VelocityChange
        }
    }
}
