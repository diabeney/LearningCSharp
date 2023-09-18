using static System.Math;

namespace CircleModel {
    class Circle {
        private int radius;
        private int type, plane;
        public static int numOfCircles;
        public Circle() {
            radius = 0;
            numOfCircles++;
            plane = 1;
            type = 2;
        }
        public Circle(int initialRadius) {
            radius = initialRadius;
            numOfCircles++;
            plane = 3;
            type = 4;

        } 

        public void Deconstruct(out int type,out int plane) {
            type = this.type;
            plane = this.plane;
        }


        public  double Area() {
            return PI * radius * radius;
        }
    }
}