using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameObjectTilemap : MonoBehaviour
{
    [SerializeField] private Tilemap map;
    private readonly Dictionary<Vector3Int, GameObject> placedObjects = new();

    public GameObject GetObjectAt(Vector3Int position)
    {
        return placedObjects[position];
    }

    public bool HasObjectAt(Vector3Int position)
    {
        return placedObjects.ContainsKey(position);
    }

    public bool TryPlaceObjectAt(Vector3Int position, ref GameObject obj)
    {
        bool result = false;
        if(obj != null && position != null && placedObjects.ContainsKey(position))
        {
            obj.transform.position = map.CellToWorld(position);
            placedObjects[position] = obj;
            result = true;
        }
        return result;
    }

    public void PlaceObjectAt(Vector3Int position, ref GameObject obj, bool destroyExisting = true)
    {
        if(obj != null && position != null)
        {
            if (placedObjects.ContainsKey(position))
            {
                if (destroyExisting)
                {
                    Destroy(placedObjects[position]);
                }
                placedObjects[position] = obj;
            }
            else
            {
                placedObjects.Add(position, obj);
            }
            obj.transform.position = map.CellToWorld(position);
        }
    }

    public bool TryPlaceObjectAt(ref GameObject obj, int x, int y, int z = 0)
    {
        Vector3Int position = new(x, y, z);
        return TryPlaceObjectAt(position, ref obj);
    }

    public void PlaceObjectAt(ref GameObject obj, int x, int y, int z = 0)
    {
        PlaceObjectAt(new Vector3Int(x, y, z), ref obj);
    }

    public Vector3 CellToWorld(Vector3Int position)
    {
        return map.CellToWorld(position);
    }

    public Vector3 CellToWorld(int x, int y, int z = 0)
    {
        return map.CellToWorld(new Vector3Int(x, y, z));
    }
}
