using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    int spawnsayısı = 0;
    public GameObject rocket;
    public GameObject astroid1;
    public GameObject astronot;
    public GameObject cell;
    public GameObject materyel;
    public GameObject alien;
    public GameObject karedelik1;
    int counterAstroid, counterAstronot, counterEnergy, counterMaterial, counterBlackHole, counterAlien ;
    



    void Start()
    {
        counterAstroid = 50;
        counterAstronot = 750;
        counterEnergy = 1000;
        counterMaterial = 50;
        counterBlackHole = 700;
        counterAlien = 430;

        

        for (int i = 0; i < 10; i++)
        {

            Vector3 randomSpawnPosition = new Vector3(Random.Range(12f, -12f), 0.40f, Random.Range(counterAstroid, counterAstroid + 150));

            Instantiate(astroid1, randomSpawnPosition, Quaternion.identity);
            counterAstroid += 50;
            
        }

        for (int i = 0; i < 3; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(3, -3), -2f, Random.Range(counterAstronot, counterAstronot + 150));
            Instantiate(astronot, randomSpawnPosition, Quaternion.identity);
            counterAstronot += 750;

        }
        for (int i = 0; i < 2; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(3, -3), -3.5f, Random.Range(counterEnergy, counterEnergy + 50));
            Instantiate(cell, randomSpawnPosition, Quaternion.identity);
            counterEnergy += 1050;
        }
        for (int i = 0; i < 10; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(12f, -11f), -2f, Random.Range(counterMaterial, counterMaterial + 100));
            Instantiate(materyel, randomSpawnPosition, Quaternion.identity);
            counterMaterial += 150;
        }
        for (int i = 0; i < 2; i++)
        {

            Vector3 randomSpawnPosition = new Vector3(Random.Range(12f, -11f), 0.54f, Random.Range(counterBlackHole, counterBlackHole + 50));
            Instantiate(karedelik1, randomSpawnPosition, Quaternion.identity);
            counterBlackHole += 750;
        }
        for (int i = 0; i < 5; i++)
        {

            Vector3 randomSpawnPosition = new Vector3(Random.Range(12f, -11f), 0.54f, Random.Range(counterAlien, counterAlien + 50));
            Instantiate(alien, randomSpawnPosition, Quaternion.identity);
            counterAlien += 450;
        }


    }


    //bu fonksiyonla carpma sonrasinda seklin yok olmasini ve ardindan reborn fonksiyonuyla belirlenen noktada spawnlanmasi saglanir.
    //Reborn fonksiyonu cagrilma sirasinda ilk olarak gameobject ve ardindan pozisyonunun z koordinati parantezin icerisine yazilmalidir.
    
   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
        
            astroid1.SetActive(false);
            Reborn(astroid1, astroid1.transform.position.z);
            astroid1.SetActive(true);
        }
        if (collision.gameObject.tag == "astro")
        {
            astronot.SetActive(false);
            Reborn(astronot, astronot.transform.position.z);
            astronot.SetActive(true);
        }
        if (collision.gameObject.tag == "cell")
        {
            cellses.Play();
            cell.SetActive(false);
            Reborn(cell, cell.transform.position.z);
            cell.SetActive(true);

        }
        if (collision.gameObject.tag == "ore")
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
    public void Reborn(GameObject gameObject, float positionZ)
    {
    firstPoint:
        float xPosition, zPosition;
        xPosition = Random.Range(-3, 3);
        zPosition = Random.Range(positionZ + 50, positionZ + 100);
        Vector3 spawnPosition = new Vector3(xPosition, 0, zPosition);
        gameObject.transform.position = spawnPosition;
        if (rocket.transform.position.z > spawnPosition.z)
            goto firstPoint;


    }*/

}