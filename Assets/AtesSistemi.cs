using UnityEngine;
using UnityEngine.InputSystem; // 1. Bu satýrý en üste ekle

public class AtesSistemi : MonoBehaviour
{
    public GameObject mermiPrefab;
    public float mermiHizi = 2000f;

    void Update()
    {
        // 2. Yeni sistemde basitçe tuþ kontrolü:
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject yeniMermi = Instantiate(mermiPrefab, transform.position, transform.rotation);
        yeniMermi.GetComponent<Rigidbody>().AddForce(transform.forward * mermiHizi);
        Destroy(yeniMermi, 2f);
    }
}