using UnityEngine;

public class SlidingPuzzle : MonoBehaviour
{
    [SerializeField] private transform gameTransform; //where to store/scale puzzle
    [SerializeField] private transform piecePrefab;    

    private int emptyLocation;
    private int size;
    }


    // Create the game setup with size x size pieces

private void CreateGamePieces(float gapThickness)
{
    //width of each tile
    float width = 1 / (float)size;
    for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; coll++)
            {
                Transform piece = Instantiate(piecePrefab, gameTransform);
               // game pieces will be going from -1 to +1
               piece.localPosition = new Vector3(-1 + (2* width * col) + width,
                                                 +1 -(2 * width * row) - width,
                                                0);
            }
        }
}

void Start() 
{
    size = 3; // total size of the game 
    CreateGamePieces(0.01f); //thickness between tiles
}
