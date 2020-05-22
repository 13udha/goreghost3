using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New Mesh Variable", menuName = "UCINGEN/Variables/Mesh")]
    public class MeshVariable : ScriptableObject
    {
        public Mesh Mesh;

        public void SetMesh(Mesh newMesh)
        {
            Mesh = newMesh;
        }
    }
}
