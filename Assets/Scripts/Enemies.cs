using System.Collections;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public GameObject[] enemies;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            int enemy = Random.Range(0, enemies.Length);
            if (enemy > enemies.Length) enemy = 0;

            float time = Random.Range(0.1f, 1);
            yield return new WaitForSeconds(time);

            Vector3 position = transform.position;
            position.x = Random.Range(-3, 3);

            GameObject newEnemy =
                Instantiate(
                    enemies[enemy],
                    position,
                    transform.rotation);

            Destroy(newEnemy, 6);
        }
    }
}

