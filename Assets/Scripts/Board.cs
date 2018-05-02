using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour {

    public GameObject CellPrefab;

    [HideInInspector]
    public Cell[,] AllCells = new Cell[8, 8];

    public void Create()
    {
        //Create
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                //Create the cell
                GameObject newCell = Instantiate(CellPrefab, transform);

                //Position
                RectTransform rectTransform = newCell.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2((x * 100) + 50, (y * 100) + 50);

                //Setup
                AllCells[x, y] = newCell.GetComponent<Cell>();
                AllCells[x, y].Setup(new Vector2Int(x, y), this);

                //Color
                if (x % 2 == 0 && y % 2 != 0 || x % 2 != 0 && y % 2 == 0 )
                {  
                   AllCells[x, y].GetComponent<Image>().color = new Color(230f / 255f, 220f / 255f, 187f / 255f, 255f / 255f);
                }
            }
        }

        //Color
        //for (int x = 0; x < 8; x += 2)
        //{
        //    for (int y = 0; y < 8; y++)
        //    {
        //        // Offset for every other line
        //        int offset = (y % 2 != 0) ? 0 : 1;
        //        int finalX = x + offset;

        //        //Color
        //        AllCells[finalX, y].GetComponent<Image>().color = new Color(230f / 255f, 220f / 255f, 187f / 255f, 255f / 255f);
        //    }
        //}
    }

}
