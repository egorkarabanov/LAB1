using System;

namespace LAB1 {
    public class Rectangle {
        private int[] point_1, point_2;

        public void Point_1(int x, int y) {
            point_1[0] = x;
            point_1[1] = y;
        }

        public void Point_2(int x, int y) {
            point_2[0] = x;
            point_2[1] = y;
        }

        public (int, int) find_sides() {
            return (Math.Abs(point_1[0]-point_2[0]), Math.Abs(point_1[1]-point_2[1]));
        }

        public Rectangle() {
            point_1 = new int[2];
            point_2 = new int[2];
        }
        
    }
}