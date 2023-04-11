namespace TimeSpace {
    class Time {
        public const byte SecondsInMinute = 60;
        public const byte MinutesInHour = 60;
        public const ushort SecondsInHour = SecondsInMinute * MinutesInHour;
        public Time(ulong seconds = 0) {
            this.Seconds = seconds;
        }
        public ulong Seconds { get; private set; }
        public ulong Minutes { get => Seconds/SecondsInMinute; }
        public ulong Hours { get => Seconds/SecondsInHour; }
        public void ChangeTimeBySeconds(ulong seconds) {
            this.Seconds = seconds;
        }
        public void ChangeTimeByMinutese(ulong minutes) {
            this.Seconds = minutes * SecondsInMinute;
        }
        public void ChangeTimeByHours(ulong hours) {
            this.Seconds = hours * SecondsInHour;
        }
        public override string ToString() {
            return $"{this.Hours}:{this.Minutes % MinutesInHour:00}:{this.Seconds % SecondsInMinute:00}";
        }
        /*public override bool Equals(object obj) {
            return this.Seconds == ((Time)obj).Seconds;
        } //*/
        /*public override int GetHashCode() {
            return (unchecked((int)((long)this.Seconds)) ^ (int)(this.Seconds >> 32));
        } //*/
    }
}