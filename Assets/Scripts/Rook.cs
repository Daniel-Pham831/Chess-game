using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessPiece
{
    protected override List<Vector2Int> GetAllPossibleMove()
    {
        return new List<Vector2Int>();
    }
}