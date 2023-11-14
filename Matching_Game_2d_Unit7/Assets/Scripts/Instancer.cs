using UnityEngine;
[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    public void CreateInstance(GameObject obj)
    {
        Instantiate(obj);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        for (var i = 0; i < obj.vector3Dlist.Count; i++)
        {
            Instantiate(prefab, obj.vector3Dlist[i].value, Quaternion.identity);
        }
    }
    
    public void CreateInstanceFromCounting(Vector3DataList obj)
    {
        num = obj.vector3Dlist.Count;
        Instantiate(prefab, obj.vector3Dlist[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3Dlist.Count)
        {
            num = 0;
        }
    }

    public void CreateInstanceFromRandom(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3Dlist.Count - 1);
        Instantiate(prefab, obj.vector3Dlist[num].value, Quaternion.identity);
    }

}
