using UnityEngine;
public class Spawning : MonoBehaviour
{

    [SerializeField] private GameObject prefab;

    [SerializeField] float spawnDelay = 1f;

    [SerializeField] float maxHeight = 1f;

    [SerializeField] float minHeight = -1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnDelay, spawnDelay);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }

}
