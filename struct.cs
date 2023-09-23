namespace Structures {
    struct Time {
        private int hours, minutes, seconds;

        public Time(int hh, int mm, int ss) {
            this.hours = hh;
            this.minutes = mm;
            this.seconds = ss;
        }

        public int Hours() {
            return this.hours;
        }
    }
}