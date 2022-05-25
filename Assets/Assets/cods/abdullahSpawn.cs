using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSonsuz: MonoBehaviour
{
    int spawnsayısı = 0;
    public GameObject rocket;
    public GameObject astroid1;
    public GameObject astronot;
    public GameObject cell;
    public GameObject materyel;
    public GameObject alien;
    public GameObject karedelik1;
    int counterAstroid, counterAstronot, counterEnergy ,counterMaterial , counterBlackHole , counterAlien= 0;

    void Start()
    {
        
        for (int i = 0; i < 10; i++)
        {
            
            Vector3 randomSpawnPosition = new Vector3(Random.Range(3,-3), 0.40f, Random.Range(counterAstroid, counterAstroid + 50));
            Instantiate(astroid1, randomSpawnPosition, Quaternion.identity);
            counterAstroid += 50;
        }

        for (int i = 0; i < 3; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(3, -3), 0f, Random.Range(counterAstronot, counterAstronot+50));
            Instantiate(astronot, randomSpawnPosition, Quaternion.identity);
            counterAstronot += 50;

        }
        for (int i = 0; i < 2; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(3, -3), -3.5f, Random.Range(counterEnergy, counterEnergy+50));
            Instantiate(cell, randomSpawnPosition, Quaternion.identity);
            counterEnergy += 50;
        }
        for (int i = 0; i < 10; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(12f, -11f), 0.40f, Random.Range(counterMaterial, counterMaterial+50));
            Instantiate(materyel, randomSpawnPosition, Quaternion.identity);
            counterMaterial += 50;
        }
        for (int i = 0; i < 2; i++)
        {

            Vector3 randomSpawnPosition = new Vector3(Random.Range(12f, -11f), 0.54f, Random.Range(counterBlackHole, counterBlackHole+50));
            Instantiate(karedelik1, randomSpawnPosition, Quaternion.identity);
            counterBlackHole += 50;
        }
        for (int i = 0; i < 10; i++)
        {

            Vector3 randomSpawnPosition = new Vector3(Random.Range(12f, -11f), 0.54f, Random.Range(counterAlien,counterAlien+50));
            Instantiate(alien, randomSpawnPosition, Quaternion.identity);
            counterAlien += 50;
        }


    }


    //bu fonksiyonla carpma sonrasinda seklin yok olmasini ve ardindan reborn fonksiyonuyla belirlenen noktada spawnlanmasi saglanir.
    //Reborn fonksiyonu cagrilma sirasinda ilk olarak gameobject ve ardindan pozisyonunun z koordinati parantezin icerisine yazilmalidir.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "astroide")
        {
            astroid1.SetActive(false);
            Reborn(astroid1,astroid1.transform.position.z);
            astroid1.SetActive(true);
        }
        if (collision.gameObject.tag == "astronot")
        {
            astronot.SetActive(false);
            Reborn(astronot,astronot.transform.position.z);
            astronot.SetActive(true);
        }
        if (collision.gameObject.tag == "energy")
        {
            cell.SetActive(false);
            Reborn(cell, cell.transform.position.z);
            cell.SetActive(true);

        }
        if(collision.gameObject.tag=="materyel")
        {
            materyel.SetActive(false);
            Reborn(materyel, materyel.transform.position.z);
            materyel.SetActive(true);

        }
        if (collision.gameObject.tag == "alien")
        {
            alien.SetActive(false);
            Reborn(alien, alien.transform.position.z);
            alien.SetActive(true);

        }
        if (collision.gameObject.tag == "blackhole")
        {
            karedelik1.SetActive(false);
            Reborn(karedelik1, karedelik1.transform.position.z);
            karedelik1.SetActive(true);
        }

    }

    //bu fonksiyonla random bir nokta tayini gerceklestiriyoruz.
    public void Reborn(GameObject gameObject,float positionZ)
    {
        firstPoint:
        float xPosition, zPosition;
        xPosition = Random.Range(-3, 3);
        zPosition = Random.Range(positionZ+50, positionZ+100);
        Vector3 spawnPosition = new Vector3(xPosition, 0, zPosition);
        gameObject.transform.position = spawnPosition;
        if (rocket.transform.position.z > spawnPosition.z)
            goto firstPoint;


    }

}