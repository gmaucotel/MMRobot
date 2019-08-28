using System;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotInstance toy = null;
            while (true)
            {
                string[] line = Console.ReadLine().Split();
                if (toy==null)
                {
                    if (line[0].CompareTo("PLACE") == 0 && line.Length == 2)
                    {
                        string[] vals = line[1].Split(",");
                        if (vals.Length == 3)
                        {
                            string dir = vals[2];
                            try
                            {
                                int x = Convert.ToInt32(vals[0]);
                                int y = Convert.ToInt32(vals[1]);
                                toy = new RobotInstance(dir, x, y);
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                    // else is not required as invalid arguments have to be ignored
                }
                else
                {
                    try
                    {
                        switch (line[0])
                        {
                            case "LEFT":
                                toy.Rotate(line[0]);
                                break;
                            case "RIGHT":
                                toy.Rotate(line[0]);
                                break;
                            case "MOVE":
                                toy.Move();
                                break;
                            case "REPORT":
                                Console.WriteLine(toy.ToString());
                                break;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}
