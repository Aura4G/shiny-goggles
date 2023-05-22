using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon_database
{
    class databaseOperations
    {
        public static void sortDex(ref List<pokemon> records)
        {
            pokemon tempValue;
            for (int i = 1; i < records.Count; i++)
            {
                for (int j = 0; j < records.Count - i; j++)
                {
                    if (records[j].dexNum > records[j + 1].dexNum)
                    {
                        tempValue = records[j];
                        records[j] = records[j + 1];
                        records[j + 1] = tempValue;
                    }
                }
            }
        }

        public static bool alreadyPresent(List<pokemon> records, int monDexNum)
        {
            bool isHere = false;
            for (int i = 0; i < records.Count; i++)
            {
                if (monDexNum == records[i].dexNum)
                {
                    isHere = true;
                    Console.WriteLine(records[i].dexNum.ToString() + ", " + records[i].monName + ", " + records[i].Type1 + ", " +
                    records[i].Type2 + ", " + records[i].HP.ToString() + ", " + records[i].attack.ToString() + ", " +
                    records[i].defence.ToString() + ", " + records[i].spAttack.ToString() + ", " +
                    records[i].spDefence.ToString() + ", " + records[i].speed.ToString() + ", " + records[i].ability);
                }
            }

            return isHere;
        }
    }
}
