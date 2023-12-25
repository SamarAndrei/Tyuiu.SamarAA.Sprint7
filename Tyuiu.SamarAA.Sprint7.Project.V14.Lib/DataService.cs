using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Tyuiu.SamarAA.Sprint7.Project.V14.Lib
{
    public class DataService
    {

        public string[] GetPaths(string path, string nom)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string way ="";
            foreach (string line in lines)
            {
                string[] str = line.Split(';');
                if (str[0] == nom)
                {
                    for(int i = 0; i < str.Length; i++)
                    {
                        if (i == str.Length - 1)
                        {
                            way += str[i];
                        }
                        else
                        {
                            way += str[i]+";";
                        }
                    }
                }
            }
            string[] res = way.Split(';');

            return res;
        }

        public int[] GetStat(string path)
        {
            int avt = 0;
            int mini = 0;
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] str = line.Split(';');
                if(str[1] == "автобус")
                {
                    avt += 1;
                }
                else
                {
                    mini += 1;
                }
            }
            int[] res = new int[2];
            res[0] = avt;
            res[1] = mini;

            return res;
        }

        public int GetStatMin(string path)
        {
            int count = 0;
            int min = 1000;
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach(string line in lines)
            {
                string[] str = line.Split(';');
                for(int i = 0; i < str.Length; i++)
                {
                    count += 1;
                }
                count -= 2;
                min = Math.Min(min, count);
                count = 0;
            }

            return min;
        }

        public int GetStatAvg(string path)
        {
            int count = 0;
            int avt = 0;
            int avg = 0;
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] str = line.Split(';');
                for (int i = 0; i < str.Length; i++)
                {
                    count += 1;
                }
                count -= 2;
                avt += 1;
            }

            return count/avt;
        }

        public int GetStatMax(string path)
        {
            int count = 0;
            int max = 0;
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] str = line.Split(';');
                for (int i = 0; i < str.Length; i++)
                {
                    count += 1;
                }
                count -= 2;
                max = Math.Max(max, count);
                count = 0;
            }

            return max;
        }
    }
}
