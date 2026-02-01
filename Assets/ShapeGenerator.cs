using UnityEngine;

public class ShapeGenerator : MonoBehaviour
{
    public GameObject squarePrefab; // Buraya bir Cube veya Sprite sürükle
    public int count = 5;           // Kaç tane obje basýlacak?
    public float spacing = 1.1f;    // Objelerin arasýndaki mesafe

    void Start()
    {
        GenerateVerticalLine();
    }

    void GenerateVerticalLine()
    {
        for (int i = 0; i < count; i++)
        {
            // Pozisyonu her adýmda aþaðýya doðru kaydýrýyoruz
            // Vector3.down (0, -1, 0) deðerine sahiptir
            Vector3 spawnPosition = transform.position + (Vector3.down * i * spacing);

            // Objeyi oluþtur
            Instantiate(squarePrefab, spawnPosition, Quaternion.identity);
        }
    }
}