using System.Collections.Generic;

public static class Levels
{
    //From bottom to top & from front to back
    static int[,,] level1 = {
        {
            { 1, 1, 1, 1 },{ 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }
        },
        {
            { 1, 1, 1, 1 }, { 1, 0, 0, 1 }, { 1, 0, 0, 1 }, { 1, 1, 1, 1 }
        },
        {
            { 1, 1, 1, 1 }, { 1, 0, 0, 1 }, { 1, 0, 0, 1 }, { 1, 1, 1, 1 }
        },
        {
            { 1, 1, 1, 1 },{ 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }
        }


    };

    public static int[,,] GetLevel(int levelNo)
    {
        return level1;
        /*switch (levelNo)
        {
            case 1:
                
            default:
                break;
        }*/
    }




}
