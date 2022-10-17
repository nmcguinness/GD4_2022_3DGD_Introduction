using UnityEngine;

namespace GD
{
    /// <summary>
    /// Combines non-static meshes at runtime to reduce Batch and SetPass calls
    /// </summary>
    /// <see cref="http://www.vfkjsd.cn/unity3d/ScriptReference/Mesh.CombineMeshes.html"/>
    /// <seealso cref="https://github.com/KellanHiggins/UnityFBXExporter"/>
    [RequireComponent(typeof(MeshFilter))]
    [RequireComponent(typeof(MeshRenderer))]
    public class MeshCombiner : MonoBehaviour
    {
        private void Start()
        {
            MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();
            CombineInstance[] combine = new CombineInstance[meshFilters.Length];
            int i = 0;
            while (i < meshFilters.Length)
            {
                combine[i].mesh = meshFilters[i].sharedMesh;
                combine[i].transform = meshFilters[i].transform.localToWorldMatrix;
                meshFilters[i].gameObject.SetActive(false);
                i++;
            }
            transform.GetComponent<MeshFilter>().mesh = new Mesh();
            transform.GetComponent<MeshFilter>().mesh.CombineMeshes(combine);
            transform.gameObject.SetActive(true);

            transform.localScale = Vector3.one;
            transform.rotation = Quaternion.identity;
            transform.position = Vector3.zero;
        }
    }
}