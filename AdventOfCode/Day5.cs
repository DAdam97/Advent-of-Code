using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day5 : Puzzle
    {
        public override void part1()
        {
            List<Point> points = new List<Point>();
            int max_x = 0;
            int max_y = 0;

            int dangerousAreas = 0;

            for (int i = 0; i < inputs.Count; i++)
            {
                string scanLine = inputs[i];
                string[] coordinatePair = scanLine.Replace(" -> ", ":").Split(':');
                string[] startSegment = coordinatePair[0].Split(',');
                string[] endSegment = coordinatePair[1].Split(',');

                int x1 = int.Parse(startSegment[0]);
                int y1 = int.Parse(startSegment[1]);
                int x2 = int.Parse(endSegment[0]);
                int y2 = int.Parse(endSegment[1]);

                if (x1 > max_x) max_x = x1;
                if (y1 > max_y) max_y = y1;

                if ((x1 == x2) || (y1 == y2))
                {
                    points.Add(new Point(x1, y1));
                    points.Add(new Point(x2, y2));
                }
            }


            int[,] oceanFloor = new int[max_x + 1, max_y + 1];

            for (int i = 0; i < points.Count; i += 2)
            {
                Point start = points[i];
                Point end = points[i + 1];

                AddHidrothermalVentLine(start, end, oceanFloor);
            }


            for (int y = 0; y < oceanFloor.GetLength(1); y++)
            {
                for (int x = 0; x < oceanFloor.GetLength(0); x++)
                {
                    if (oceanFloor[x, y] >= 2)
                    {
                        dangerousAreas++;
                    }
                }
            }

            Console.WriteLine(dangerousAreas);
        }

        public override void part2()
        {
            List<Point> points = new List<Point>();
            int max_x = 0;
            int max_y = 0;

            int dangerousAreas = 0;

            for (int i = 0; i < inputs.Count; i++)
            {
                string scanLine = inputs[i];
                string[] coordinatePair = scanLine.Replace(" -> ", ":").Split(':');
                string[] startSegment = coordinatePair[0].Split(',');
                string[] endSegment = coordinatePair[1].Split(',');

                int x1 = int.Parse(startSegment[0]);
                int y1 = int.Parse(startSegment[1]);
                int x2 = int.Parse(endSegment[0]);
                int y2 = int.Parse(endSegment[1]);             

                if (x1 > max_x) max_x = x1;
                if (x2 > max_x) max_x = x2;

                if (y1 > max_y) max_y = y1;
                if (y2 > max_y) max_y = y2;

                points.Add(new Point(x1, y1));
                points.Add(new Point(x2, y2));
            }


            int[,] oceanFloor = new int[max_x + 1, max_y + 1];

            for (int i = 0; i < points.Count; i += 2)
            {
                Point start = points[i];
                Point end = points[i + 1];

                AddHidrothermalVentLine(start, end, oceanFloor);
            }


            for (int y = 0; y < oceanFloor.GetLength(1); y++)
            {
                for (int x = 0; x < oceanFloor.GetLength(0); x++)
                {
                    if (oceanFloor[x, y] >= 2)
                    {
                        dangerousAreas++;
                    }
                }
            }

            Console.WriteLine(dangerousAreas);
        }


        private void AddHidrothermalVentLine(Point start, Point end, int[,] oceanFloor)
        {
            int dx = Math.Abs(end.X - start.X);
            int dy = Math.Abs(end.Y - start.Y);
            int sx = Math.Sign(end.X - start.X);
            int sy = Math.Sign(end.Y - start.Y);

            bool swap = false;

            if (dx < dy)
            {
                int temp = dx;
                dx = dy;
                dy = temp;
                swap = true;
            }

            int d = 2 * dy - dx;
            int x = start.X;
            int y = start.Y;

            oceanFloor[x, y]++;

            while ((x != end.X) || (y != end.Y))
            {
                if (d > 0)
                {
                    if (swap) x += sx;
                    else y += sy;
                    d -= 2 * dx;
                }

                if (swap) y += sy;
                else x += sx;

                d += 2 * dy;

                oceanFloor[x, y]++;
            }
        }

        private void displayOceanFloor(int[,] oceanFloor)
        {
            for (int y = 0; y < oceanFloor.GetLength(0); y++)
            {
                for (int x = 0; x < oceanFloor.GetLength(1); x++)
                {
                    Console.Write(oceanFloor[x, y] + " ");
                }
                Console.WriteLine();
            }
        }


        public Day5(string input) : base(input) { }
    }
}
