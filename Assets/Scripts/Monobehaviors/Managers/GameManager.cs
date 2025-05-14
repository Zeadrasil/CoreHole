using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private int minX;
    [SerializeField] private int maxX;
    [SerializeField] private int minY;
    [SerializeField] private int maxY;
    [SerializeField] private int minZ;
    [SerializeField] private int maxZ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerationManager.Instance.BasicGenerate(minX, minY, minZ, maxX, maxY, maxZ);
    }
}
